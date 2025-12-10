using bussijaama_haaldus_projekt_u2_api.Data;
using bussijaama_haaldus_projekt_u2_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Route = bussijaama_haaldus_projekt_u2_api.Models.Route;

namespace bussijaama_haaldus_projekt_u2_api.Controllers
{
    [ApiController]
    [Route("api/routes")]
    [Produces("application/json")]
    public class RoutesController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly ILogger<RoutesController> _logger;

        public RoutesController(AppDbContext db, ILogger<RoutesController> logger)
        {
            _db = db;
            _logger = logger;
        }

        // GET: api/routes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Route>>> GetRoutes(
            [FromQuery] string? departureCity,
            [FromQuery] string? destinationCity,
            [FromQuery] string? company,
            [FromQuery] DateTime? date)
        {
            try
            {
                IQueryable<Route> query = _db.Routes.AsNoTracking();

                // Убираем пробелы и приводим к нижнему регистру для поиска
                if (!string.IsNullOrWhiteSpace(departureCity))
                {
                    var searchDep = departureCity.Trim().ToLowerInvariant();
                    query = query.Where(r => r.DepartureCity != null &&
                        r.DepartureCity.ToLower().Contains(searchDep));
                }

                if (!string.IsNullOrWhiteSpace(destinationCity))
                {
                    var searchDest = destinationCity.Trim().ToLowerInvariant();
                    query = query.Where(r => r.DestinationCity != null &&
                        r.DestinationCity.ToLower().Contains(searchDest));
                }

                if (!string.IsNullOrWhiteSpace(company))
                {
                    var searchComp = company.Trim().ToLowerInvariant();
                    query = query.Where(r => r.Company != null &&
                        r.Company.ToLower().Contains(searchComp));
                }

                if (date.HasValue)
                {
                    var searchDate = date.Value.Date;
                    query = query.Where(r => r.DepartureTime.Date == searchDate);
                }

                query = query.OrderBy(r => r.DepartureTime);

                var routes = await query.ToListAsync();
                return Ok(routes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching routes list");
                return StatusCode(500, new { error = "Serveri viga marsruutide laadimisel" });
            }
        }

        // GET: api/routes/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Route>> GetRoute(int id)
        {
            try
            {
                var route = await _db.Routes.AsNoTracking()
                    .FirstOrDefaultAsync(r => r.Id == id);

                if (route == null)
                    return NotFound(new { error = $"Route with ID {id} not found" });

                return Ok(route);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving route with ID {RouteId}", id);
                return StatusCode(500, new { error = "Internal server error" });
            }
        }

        // POST: api/routes
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Route>> CreateRoute([FromBody] Route route)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(new { error = "Invalid data", details = ModelState });

                route.Id = 0; // ensure it's treated as new entity

                _db.Routes.Add(route);
                await _db.SaveChangesAsync();

                return CreatedAtAction(nameof(GetRoute), new { id = route.Id }, route);
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Database error while creating route");
                return Conflict(new { error = "Could not create route – possible data conflict or constraint violation" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error while creating route");
                return StatusCode(500, new { error = "Internal server error while creating route" });
            }
        }

        // PUT: api/routes/{id}
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Route>> UpdateRoute(int id, [FromBody] Route route)
        {
            if (id != route.Id)
                return BadRequest(new { error = "Route ID in URL and body do not match" });

            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(new { error = "Invalid data", details = ModelState });

                // Вот правильный способ — не Entry().State, а Update()
                _db.Routes.Update(route);  // ← ЭТО РЕШЕНИЕ
                await _db.SaveChangesAsync();

                return Ok(route);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _db.Routes.AnyAsync(r => r.Id == id))
                    return NotFound(new { error = $"Route with ID {id} no longer exists" });
                return Conflict(new { error = "Concurrency conflict" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error while updating route ID {RouteId}", id);
                return StatusCode(500, new { error = "Internal server error" });
            }
        }

        // DELETE: api/routes/{id}
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteRoute(int id)
        {
            try
            {
                var route = await _db.Routes.FindAsync(id);

                if (route == null)
                    return NotFound(new { error = $"Route with ID {id} not found" });

                _db.Routes.Remove(route);
                await _db.SaveChangesAsync();

                return Ok(new { message = "Route successfully deleted", id });
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Cannot delete route ID {RouteId} – foreign key constraint", id);
                return Conflict(new { error = "Cannot delete route because it is referenced by other records (e.g. tickets)" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error while deleting route ID {RouteId}", id);
                return StatusCode(500, new { error = "Internal server error" });
            }
        }
    }
}
// Controllers/RoutesController.cs
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
    public class RoutesController : ControllerBase
    {
        private readonly AppDbContext _db;

        public RoutesController(AppDbContext db)
        {
            _db = db;
        }

        // GET: api/routes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Route>>> GetRoutes(
            [FromQuery] string? departureCity,
            [FromQuery] string? destinationCity,
            [FromQuery] string? company,
            [FromQuery] DateTime? date)
        {
            IQueryable<Route> query = _db.Routes.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(departureCity))
                query = query.Where(r => r.DepartureCity.Contains(departureCity.Trim(), StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(destinationCity))
                query = query.Where(r => r.DestinationCity.Contains(destinationCity.Trim(), StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(company))
                query = query.Where(r => r.Company.Contains(company.Trim(), StringComparison.OrdinalIgnoreCase));

            if (date.HasValue)
                query = query.Where(r => r.DepartureTime.Date == date.Value.Date);

            query = query.OrderBy(r => r.DepartureTime);

            return Ok(await query.ToListAsync());
        }

        // GET: api/routes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Route>> GetRoute(int id)
        {
            var route = await _db.Routes.FindAsync(id);
            if (route == null) return NotFound();
            return Ok(route);
        }

        // POST: api/routes
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Route>> CreateRoute([FromBody] Route route)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            route.Id = 0;

            _db.Routes.Add(route);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRoute), new { id = route.Id }, route);
        }

        // PUT: api/routes/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Route>> UpdateRoute(int id, [FromBody] Route route)
        {
            if (id != route.Id) return BadRequest("ID в пути и теле не совпадают");

            if (!ModelState.IsValid) return BadRequest(ModelState);

            _db.Entry(route).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_db.Routes.Any(e => e.Id == id))
                    return NotFound();
                throw;
            }

            return Ok(route);
        }

        // DELETE: api/routes/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteRoute(int id)
        {
            var route = await _db.Routes.FindAsync(id);
            if (route == null) return NotFound();

            _db.Routes.Remove(route);
            await _db.SaveChangesAsync();

            return Ok(new { message = "Marsruut kustutatud", id = id });
        }
    }
}
using bussijaama_haaldus_projekt_u2_api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Route = bussijaama_haaldus_projekt_u2_api.Models.Route;

namespace bussijaama_haaldus_projekt_u2_api.Data
{
    public class AppDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

        public DbSet<Route> Routes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Route>().HasData();

            var routes = new List<Route>();
            var random = new Random(42);

            var companies = new[] { "Lux Express", "NordBus", "Baltic Shuttle", "Ecolines", "FlixBus" };
            var cities = new (string From, string To, string FromStation, string ToStation, decimal BasePrice, int BaseMinutes)[]
                {
                    ("Tallinn",  "Tartu",     "Tallinn Bus Station",      "Tartu Bus Station",      12.50m, 150),
                    ("Tallinn",  "Pärnu",     "Tallinn Bus Station",      "Pärnu Bus Station",      10.00m, 110),
                    ("Tallinn",  "Narva",     "Tallinn Bus Station",      "Narva Bus Station",      11.00m, 160),
                    ("Tallinn",  "Viljandi",  "Tallinn Bus Station",      "Viljandi Bus Station",   13.00m, 140),
                    ("Tartu",    "Tallinn",   "Tartu Bus Station",        "Tallinn Bus Station",    12.50m, 150),
                    ("Pärnu",    "Tallinn",   "Pärnu Bus Station",        "Tallinn Bus Station",    10.00m, 110),
                    ("Riga",     "Tallinn",   "Riga Central Station",     "Tallinn Bus Station",    18.00m, 240),
                    ("Tallinn",  "Riga",      "Tallinn Bus Station",      "Riga Central Station",   18.00m, 240),
                    ("Tartu",    "Riga",      "Tartu Bus Station",        "Riga Central Station",   22.00m, 300)
                };

            int id = 1;
            var startDate = DateTime.Today.AddHours(6);

            for (int day = 0; day < 5; day++)
            {
                var currentDay = startDate.AddDays(day);

                foreach (var route in cities)
                {
                    int tripsPerDay = random.Next(3, 6);

                    for (int i = 0; i < tripsPerDay; i++)
                    {
                        var departure = currentDay.AddHours(7 + i * 3 + random.Next(-60, 61));
                        var durationMinutes = route.BaseMinutes + random.Next(-20, 21);
                        var arrival = departure.AddMinutes(durationMinutes);

                        var price = route.BasePrice + (decimal)random.Next(-300, 401) / 100;

                        routes.Add(new Route
                        {
                            Id = id++,
                            Number = $"BUS-{random.Next(1000, 9999)}",
                            Company = companies[random.Next(companies.Length)],
                            DepartureCity = route.From,
                            DestinationCity = route.To,
                            DepartureStation = route.FromStation,
                            DestinationStation = route.ToStation,
                            DepartureTime = departure,
                            ArrivalTime = arrival,
                            Price = Math.Round(price, 2)
                        });
                    }
                }
            }

            builder.Entity<Route>().HasData(routes.Take(30));
            var adminId = 1;
            var admin = new AppUser
            {
                Id = adminId,
                UserName = "admin@bussijaam.ee",
                NormalizedUserName = "ADMIN@BUSSIJAAM.EE",
                Email = "admin@bussijaam.ee",
                NormalizedEmail = "ADMIN@BUSSIJAAM.EE",
                FirstName = "Super",
                LastName = "Admin",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                LockoutEnabled = false,
                AccessFailedCount = 0,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                RegisteredAt = DateTime.UtcNow
            };

            var passwordHasher = new PasswordHasher<AppUser>();
            admin.PasswordHash = passwordHasher.HashPassword(admin, "Parool123!");

            builder.Entity<AppUser>().HasData(admin);

            builder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int> { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole<int> { Id = 2, Name = "User", NormalizedName = "USER" }
            );

            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int> { RoleId = 1, UserId = adminId }
            );
        }
    }
}


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

            // Seed маршрутов (оставляем как было)
            builder.Entity<Route>().HasData(
                new Route
                {
                    Id = 1,
                    Number = "BUS-1024",
                    Company = "NordBus",
                    DepartureCity = "Tallinn",
                    DestinationCity = "Tartu",
                    DepartureStation = "Tallinn Bus Station",
                    DestinationStation = "Tartu Bus Station",
                    DepartureTime = new DateTime(2025, 3, 10, 08, 00, 0),
                    ArrivalTime = new DateTime(2025, 3, 10, 10, 30, 0),
                    Price = 12.50m
                },
                new Route
                {
                    Id = 2,
                    Number = "BUS-1024",
                    Company = "NordBus",
                    DepartureCity = "Tallinn",
                    DestinationCity = "Tartu",
                    DepartureStation = "Tallinn Bus Station",
                    DestinationStation = "Tartu Bus Station",
                    DepartureTime = new DateTime(2025, 3, 10, 14, 15, 0),
                    ArrivalTime = new DateTime(2025, 3, 10, 16, 45, 0),
                    Price = 12.50m
                },
                new Route
                {
                    Id = 3,
                    Number = "BUS-2031",
                    Company = "Baltic Express",
                    DepartureCity = "Tallinn",
                    DestinationCity = "Riga",
                    DepartureStation = "Tallinn Bus Station",
                    DestinationStation = "Riga Central Station",
                    DepartureTime = new DateTime(2025, 3, 11, 07, 45, 0),
                    ArrivalTime = new DateTime(2025, 3, 11, 12, 00, 0),
                    Price = 25.00m
                },
                new Route
                {
                    Id = 4,
                    Number = "BUS-2031",
                    Company = "Baltic Express",
                    DepartureCity = "Tallinn",
                    DestinationCity = "Riga",
                    DepartureStation = "Tallinn Bus Station",
                    DestinationStation = "Riga Central Station",
                    DepartureTime = new DateTime(2025, 3, 11, 15, 30, 0),
                    ArrivalTime = new DateTime(2025, 3, 11, 19, 45, 0),
                    Price = 25.00m
                },
                new Route
                {
                    Id = 5,
                    Number = "BUS-3310",
                    Company = "EuroRoad",
                    DepartureCity = "Tallinn",
                    DestinationCity = "Vilnius",
                    DepartureStation = "Tallinn Bus Station",
                    DestinationStation = "Vilnius Bus Terminal",
                    DepartureTime = new DateTime(2025, 3, 12, 06, 00, 0),
                    ArrivalTime = new DateTime(2025, 3, 12, 14, 00, 0),
                    Price = 35.50m
                },
                new Route
                {
                    Id = 6,
                    Number = "BUS-445",
                    Company = "Lux Express",
                    DepartureCity = "Tartu",
                    DestinationCity = "Tallinn",
                    DepartureStation = "Tartu Bus Station",
                    DestinationStation = "Tallinn Bus Station",
                    DepartureTime = new DateTime(2025, 3, 10, 11, 00, 0),
                    ArrivalTime = new DateTime(2025, 3, 10, 13, 30, 0),
                    Price = 12.50m
                },
                new Route
                {
                    Id = 7,
                    Number = "BUS-778",
                    Company = "Simple Express",
                    DepartureCity = "Riga",
                    DestinationCity = "Tallinn",
                    DepartureStation = "Riga Central Station",
                    DestinationStation = "Tallinn Bus Station",
                    DepartureTime = new DateTime(2025, 3, 11, 13, 00, 0),
                    ArrivalTime = new DateTime(2025, 3, 11, 17, 15, 0),
                    Price = 22.00m
                },
                new Route
                {
                    Id = 8,
                    Number = "BUS-990",
                    Company = "Lux Express",
                    DepartureCity = "Tallinn",
                    DestinationCity = "Pärnu",
                    DepartureStation = "Tallinn Bus Station",
                    DestinationStation = "Pärnu Bus Terminal",
                    DepartureTime = new DateTime(2025, 3, 13, 09, 30, 0),
                    ArrivalTime = new DateTime(2025, 3, 13, 11, 20, 0),
                    Price = 9.90m
                }
            );

            // Создаём админа при старте
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
                new IdentityUserRole<int> { RoleId = 1, UserId = adminId } // admin имеет роль Admin
            );
        }
    }
}


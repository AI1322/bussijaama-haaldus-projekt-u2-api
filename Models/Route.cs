// Models/Route.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bussijaama_haaldus_projekt_u2_api.Models
{
    public class Route
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Number { get; set; } = string.Empty; // например: BUS-1024, BUS-3310

        [Required]
        [StringLength(100)]
        public string Company { get; set; } = string.Empty; // NordBus, Baltic Express

        // Город отправления (например: Tallinn, Riga)
        [Required]
        [StringLength(100)]
        public string DepartureCity { get; set; } = "Tallinn";

        // Город прибытия (например: Tartu, Riga, Vilnius)
        [Required]
        [StringLength(100)]
        public string DestinationCity { get; set; } = string.Empty;

        // Конкретная станция отправления
        [StringLength(150)]
        public string DepartureStation { get; set; } = "Tallinn Bus Station";

        // Конкретная станция прибытия
        [Required]
        [StringLength(150)]
        public string DestinationStation { get; set; } = string.Empty;

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        // Длительность поездки — вычисляется автоматически, не сохраняется в БД
        [NotMapped]
        public TimeSpan Duration => ArrivalTime - DepartureTime;

        [Required]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
    }
}
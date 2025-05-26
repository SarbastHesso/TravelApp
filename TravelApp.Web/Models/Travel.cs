using System.ComponentModel.DataAnnotations;

namespace TravelApp.Web.Models
{
    public class Travel
    {
        public int Id { get; set; }

        public string Destination { get; set; } = null!;

        public DateTime DepartureDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public Decimal Price { get; set; }

        public string? Description { get; set; }
    }
}

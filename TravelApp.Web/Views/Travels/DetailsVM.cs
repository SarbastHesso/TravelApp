using System.ComponentModel.DataAnnotations;

namespace TravelApp.Web.Views.Travels
{
    public class DetailsVM
    {
        public required int Id { get; set; }

        public required string Destination { get; set; } = null!;

        public required DateTime DepartureDate { get; set; }

        public required DateTime? ReturnDate { get; set; }

        public required Decimal Price { get; set; }

        public required string? Description { get; set; }
    }
}

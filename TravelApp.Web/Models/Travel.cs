using System.ComponentModel.DataAnnotations;

namespace TravelApp.Web.Models
{
    public class Travel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Destination is required.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Destination must be between 2 and 100 characters.")]
        public string Destination { get; set; } = null!;

        [Required(ErrorMessage = "Departure date is required.")]
        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReturnDate { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0, 1000000, ErrorMessage = "Price must be between 0 and 1,000,000.")]
        public Decimal Price { get; set; }

        [StringLength(500, ErrorMessage = "Description can be max 500 characters.")]
        public string? Description { get; set; }
    }
}

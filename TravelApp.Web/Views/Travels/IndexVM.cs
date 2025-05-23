using System.ComponentModel.DataAnnotations;

namespace TravelApp.Web.Views.Travels
{
    public class IndexVM
    {
        public TravelVM[] TravelsVMs { get; set; }

        public class TravelVM
        {
            public required int Id { get; set; }
            public required string Destination { get; set; }
        }
    }
}

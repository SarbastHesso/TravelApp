using TravelApp.Web.Models;

namespace TravelApp.Web.Services
{
    public class TravelService
    {
        private List<Travel> travels = 
            [
                new Travel
                {
                    Id = 1,
                    Destination = "Paris",
                    DepartureDate = new DateTime(2025, 6, 15),
                    ReturnDate = new DateTime(2025, 6, 25),
                    Price = 12000m,
                    Description = "Romantic trip to Paris."
                },
                new Travel
                {
                    Id = 2,
                    Destination = "New York",
                    DepartureDate = new DateTime(2025, 7, 10),
                    ReturnDate = new DateTime(2025, 7, 20),
                    Price = 15000m,
                    Description = "Summer vacation in New York."
                },
                new Travel
                {
                    Id = 3,
                    Destination = "Tokyo",
                    DepartureDate = new DateTime(2025, 9, 5),
                    ReturnDate = null,  // Enkel resa, inga returdato
                    Price = 18000m,
                    Description = "Business trip to Tokyo."
                }
            ];

        public Travel[] GetAll()
        {
            return travels.ToArray();
        }

        public Travel GetById(int id)
        {
            return travels.Single(t => t.Id == id);
        }

        public void AddTravel(Travel travel)
        {
            travel.Id = travels.Count > 0 ? travels.Max(e => e.Id) + 1 : 1 ;
            travels.Add(travel);
        }
    }
}

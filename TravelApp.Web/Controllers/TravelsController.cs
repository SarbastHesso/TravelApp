using Microsoft.AspNetCore.Mvc;
using TravelApp.Web.Models;
using TravelApp.Web.Services;
using TravelApp.Web.Views.Travels;

namespace TravelApp.Web.Controllers
{

    public class TravelsController(TravelService travelService) : Controller
    {
        //private static TravelService travelService = new TravelService();

        [HttpGet("")]
        public IActionResult Index()
        {
            var model = travelService.GetAll();
            IndexVM viewModel = new IndexVM()
            {
                TravelsVMs = model.Select(t => new IndexVM.TravelVM()
                {
                    Id = t.Id,
                    Destination = t.Destination,
                }).ToArray()
            };
            return View(viewModel);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(CreateVM viewModel)
        {

            Travel travel = new()
            {
                Destination = viewModel.Destination,
                DepartureDate = viewModel.DepartureDate,
                ReturnDate = viewModel.ReturnDate,
                Price = viewModel.Price,
                Description = viewModel.Description
            };

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            travelService.AddTravel(travel);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var model = travelService.GetById(id);
            DetailsVM viewModel = new DetailsVM()
            {
                Id = model.Id,
                Destination = model.Destination,
                DepartureDate = model.DepartureDate,
                ReturnDate = model.ReturnDate,
                Price = model.Price,
                Description = model.Description,
            };
            return View(viewModel);
        }
    }
}

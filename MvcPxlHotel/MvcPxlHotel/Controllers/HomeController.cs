using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcPxlHotel.Data;
using MvcPxlHotel.Models;
using MvcPxlHotel.ViewModels;

namespace MvcPxlHotel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<HotelOverviewViewModel> hotels = _context.Hotels
                .Include(x => x.HotelRooms)
                .Select(h => new HotelOverviewViewModel
                {
                    HotelName = h.HotelName,
                    HotelCountry = h.HotelCountry,
                    HotelRooms = h.HotelRooms
                });
            return View(hotels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

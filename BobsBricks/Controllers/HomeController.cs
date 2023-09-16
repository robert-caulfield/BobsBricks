using BobsBricks.Data;
using BobsBricks.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BobsBricks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            List<Product> objProductList = _db.Products.OrderByDescending(p => p.CreatedDateTime).Take(3).ToList();
            return View(objProductList);
        }

        public IActionResult RedirectToProducts()
        {
            return RedirectToAction("Index", "Product");
        }
        public IActionResult RedirectToGroupBuilds()
        {
            return RedirectToAction("Index", "GroupBuild");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
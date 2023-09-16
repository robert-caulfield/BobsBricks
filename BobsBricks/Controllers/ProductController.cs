using BobsBricks.Data;
using BobsBricks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BobsBricks.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Product> objProductList = _db.Products.ToList();
            return View(objProductList);
        }
        public IActionResult Detail(int id)
        {
            Product product = _db.Products.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            Random rnd = new Random();
            List<Product> recommendedProducts = _db.Products.Where(x => x.Id != product.Id).OrderBy(x => Guid.NewGuid()).Take(3).ToList();

            ProductDetailViewModel productDetail = new ProductDetailViewModel()
            {
                RecommendedProducts = recommendedProducts,
                MainProduct = product
            };

            return View(productDetail);
        }

        [HttpGet]
        public PartialViewResult GetProductList(string sortBy, string orderBy)
        {
            List<Product> objProductList = _db.Products.ToList();
            IEnumerable<Product> sortedList;

            switch (sortBy)
            {
                case "latest":
                    sortedList = orderBy.Equals("ascending") ? objProductList.OrderBy(x => x.CreatedDateTime) : objProductList.OrderByDescending(x => x.CreatedDateTime);
                    break;
                case "price":
                    sortedList = orderBy.Equals("ascending") ? objProductList.OrderBy(x => x.Price) : objProductList.OrderByDescending(x => x.Price);
                    break;
                case "piece":
                    sortedList = orderBy.Equals("ascending") ? objProductList.OrderBy(x => x.PieceCount) : objProductList.OrderByDescending(x => x.PieceCount);
                    break;
                default:
                    throw new ArgumentException("Invalid sortBy parameter");

            }
            
            return PartialView("_ProductList", sortedList.ToList());
        }
    }

}

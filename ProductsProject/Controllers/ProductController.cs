using Microsoft.AspNetCore.Mvc;
using ProductsProject.Data;
using ProductsProject.Models;   

namespace ProductsProject.Controllers
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
            IEnumerable<Product> objProductList = _db.Products;
            return View(objProductList);
        }
    }
}

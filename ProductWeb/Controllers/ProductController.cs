using Microsoft.AspNetCore.Mvc;

namespace ProductWeb.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

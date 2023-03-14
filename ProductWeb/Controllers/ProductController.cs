using Microsoft.AspNetCore.Mvc;
using ProductWeb.Service;

namespace ProductWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var result = this._productService.GetAllAsync();

            return View(await result);
        }
    }
}

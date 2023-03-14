using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductWeb.Models.DTO;
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

        public async Task<ActionResult> Edit(int id)
        {
            var model = await this._productService.GetByIdAsync(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditProduct model)
        {
            if (!ModelState.IsValid)
                return View(model);

            try
            {
                var result = await this._productService.UpdateAsync(model);

                if (result.Code == 1)
                {
                    return RedirectToAction("UsersByParam", "Admin");
                }
                else
                {
                    TempData["msg"] = result.Message;
                    return RedirectToAction(nameof(Edit));
                }
            }
            catch (Exception ex)
            {
                TempData["msg"] = "Unable to update the product!";
                return RedirectToAction(nameof(Edit));
            }

        }
    }
}

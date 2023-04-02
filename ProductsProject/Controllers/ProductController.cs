using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using ProductsProject.Data;
using ProductsProject.Models;
using System.Data;

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

        //GET
        public IActionResult Create()
        {
            return View();
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product obj)
        {

            var existingProduct = _db.Products.FirstOrDefault(p => p.Name == obj.Name);
            if (existingProduct != null)
            {
                ModelState.AddModelError("Name", "A product with this name already exists.");
                return View(obj);
            }

            if (ModelState.IsValid)
            {
                _db.Products.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        //GET
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var productFromDb = _db.Products.Find(id);

            if (productFromDb == null)
            {
                return NotFound();
            }

            return View(productFromDb);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product obj)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Attach(obj);

                var entry = _db.Entry(obj);
                entry.State = EntityState.Modified;
                entry.Property(e => e.CreatedDate).IsModified = false;

                // Save changes
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);
        }



        //GET
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var productFromDb = _db.Products.Find(id);

            if (productFromDb == null)
            {
                return NotFound();
            }

            return View(productFromDb);

        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Products.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Products.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }


        public IActionResult Details(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var productFromDb = _db.Products.Find(id);

            if (productFromDb == null)
            {
                return NotFound();
            }

            return View(productFromDb);
        }
    }
}

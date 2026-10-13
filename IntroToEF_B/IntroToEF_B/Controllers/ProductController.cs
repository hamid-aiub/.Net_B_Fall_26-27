using Microsoft.AspNetCore.Mvc;
using IntroToEF_B.EF;
using Microsoft.EntityFrameworkCore;
using IntroToEF_B.Models;

namespace IntroToEF_B.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _context.product.ToListAsync();
            Console.Write("Test Response: {0}", products);
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var product = _context.product.FirstOrDefault(s=>s.id == id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.product.Add(product);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Update(int id, Product product)
        {
            if (ModelState.IsValid)
            {
                var prod = _context.product.FirstOrDefault(s => s.id == id);
                if(prod == null)
                {
                    return NotFound();
                }
                prod.name = product.name;
                prod.description = product.description;
                prod.price = product.price;
                prod.stock = product.stock;
                prod.category = product.category;
                _context.SaveChanges();
                return RedirectToAction("Index");

            }

            return View(product);
        }
    }
}

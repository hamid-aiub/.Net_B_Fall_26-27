using Microsoft.AspNetCore.Mvc;
using IntroToEF_B.EF;
using Microsoft.EntityFrameworkCore;

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
            var products = await _context.Products.ToListAsync();
            Console.Write("Test Response: {0}", products);
            return View(products);
        }
    }
}

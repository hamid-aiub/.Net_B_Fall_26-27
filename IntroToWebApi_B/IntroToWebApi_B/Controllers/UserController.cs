using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IntroToWebApi_B.EF;
using IntroToWebApi_B.Model;

namespace IntroToWebApi_B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult getUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return Created();
        }

        [HttpPatch("{id}")]
        public IActionResult Update(Guid id, User user)
        {
            var existingUser = _context.Users.FirstOrDefault(s=>s.id == id);
            if (existingUser == null)
            {
                return NotFound();
            }
            existingUser.email = user.email;
            existingUser.password = user.password;
            existingUser.role = user.role;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var user = _context.Users.FirstOrDefault(s=>s.id == id);
            if (user == null)
            {
                return NotFound();
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return Ok(new { message = "User deleted successfully" });
        }

        [HttpPost("login")]


    }
}

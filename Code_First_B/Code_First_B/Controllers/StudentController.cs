using Code_First_B.EF;
using Microsoft.AspNetCore.Mvc;
using Code_First_B.Models;

namespace Code_First_B.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var students = _context.student.ToList();
            if(students.Count() < 1)
            {
                var student = new Student()
                {
                    name="Mr Rahman 101",
                    department = "CSE",
                    email = "rahman1@aiub.edu",
                    password = "12345678"
                };
                _context.student.Add(student);
                _context.SaveChanges();
            }
            ViewBag.students = students;
            return View();
        }
        public IActionResult Update(Guid id)
        {
            var student = _context.student.FirstOrDefault(s => s.id == id);
            if (student == null)
            {
                return NotFound();
            }
            student.department = "CNCS";
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            var student = _context.student.FirstOrDefault(s => s.id == id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

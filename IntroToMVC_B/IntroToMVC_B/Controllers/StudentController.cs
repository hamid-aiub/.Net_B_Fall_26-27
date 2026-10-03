using Microsoft.AspNetCore.Mvc;

namespace IntroToMVC_B.Controllers
{
    public class StudentController : Controller
    {
        // /student
        public IActionResult Index()
        {
            return View();
        }

        // /student/create
        public IActionResult Create()
        {
            return View();
        }

        // student/details/1
        public IActionResult Details(int id)
        {
            var student = new Models.StudentModel()
            {
                id = id,
                name = "John Doe",
                dept = "Computer Science",
                cgpa = 3.5f
            };

            return View(student);
        }

    }
}

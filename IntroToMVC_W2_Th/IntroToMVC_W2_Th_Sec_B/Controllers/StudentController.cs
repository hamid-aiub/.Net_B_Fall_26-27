using Microsoft.AspNetCore.Mvc;

namespace IntroToMVC_W2_Th_Sec_B.Controllers
{
    [Route("abcd")]
    public class StudentController : Controller
    {
        // localhost:port/students
        [Route("Index")]
        public IActionResult Index()
        {
            return View(); //return View("Details"); to visit Details view instead of Index view
        }

        //localhost:port/student/details
        [Route("Details/{id}")]
     public IActionResult Details(int id)
        {
            return View();
        }
}
}

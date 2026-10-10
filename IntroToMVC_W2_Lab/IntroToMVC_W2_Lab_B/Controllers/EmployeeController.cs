using Microsoft.AspNetCore.Mvc;
using IntroToMVC_W2_Lab_B.Models;

namespace IntroToMVC_W2_Lab_B.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee[] employees = new Employee[5];
            for(int i =0; i< 5; i++)
            {
                var employee = new Employee()
                {
                    id = i + 1,
                    email = "email" + i + "@example.com",
                    name = "Employee " + i,
                    age = 25 + i,
                    designation = "Designation " + i,
                    salary = 50000 + (i * 1000),
                };
                employees[i] = employee;
            }
            return View(employees);
        }
    }
}

using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index2()
         {
            var names = new String[]{"Ali", "Veli", "Deli"};
            return View(names);
         }

        public IActionResult Index1(){
            string message = $"Hello World {DateTime.Now.ToString()}";
            return View("Index1", message);
        }
        public string Index()
        {
            return "Hello World is old now. It’s time for wassup bro ;)";
        }

        public ViewResult Welcome()
        {
            return View("Index2");
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Ali", LastName = "Veli", Age = 25, Email = "aslkdjkajs@hotmail.com" },
                new Employee { Id = 2, FirstName = "Ali", LastName = "Veli", Age = 24, Email = "aslkdjkajs@hotmail.com" },
                new Employee { Id = 3, FirstName = "Ali", LastName = "Veli", Age = 15, Email = "aslkdjkajs@hotmail.com" }
            };
            return View("Index3", list);
        }
    }
}
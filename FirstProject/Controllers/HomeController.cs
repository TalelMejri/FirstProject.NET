using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Employees()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Employees(Employee emp)
        {
            Repository.AddEmployee(emp);
            return View("ConfirmVue",emp);
        }


        public ViewResult AllEmployee()
        {
            return View(Repository.GETEmployees());
        }


    }
}
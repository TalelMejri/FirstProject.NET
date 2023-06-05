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
           if(ModelState.IsValid)
            {
				Repository.AddEmployee(emp);
				return View("ConfirmVue", emp);
			}
            else
            {
                return View();
            }
         
        }


        public ViewResult AllEmployee()
        {
			//return View(Repository.GETEmployees().Where(emp=>emp.isActive==false));
			return View(Repository.GETEmployees());
		}


	}
}
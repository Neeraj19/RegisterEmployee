using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegisterEmployee.DataAccessLayer;
using RegisterEmployee.Models;

namespace RegisterEmployee.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.QuestionList = new List<string>() { "City", "Sports", "Car" };
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeDAL dal = new EmployeeDAL();
                    string result = dal.CreateEmployee(employee);
                    this.TempData["Result"] = result;
                    ModelState.Clear();
                }
            }

            catch
            {
                ModelState.AddModelError("", "Error in inserting data");
            }

            return this.View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

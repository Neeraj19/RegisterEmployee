using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RegisterEmployee.Helper;
using RegisterEmployeeAPI.Models;

namespace RegisterEmployee.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        EmployeeAPI _api = new EmployeeAPI();

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
        public async Task<ActionResult> Index(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    HttpClient client = _api.Initial();
                    HttpContent data = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
                    HttpResponseMessage result = await client.PostAsync("api/Employee/AddEmployee", data);
                    if (result.IsSuccessStatusCode)
                    {
                        this.TempData["Result"] = "Register successfully.";
                    }
                    
                    ModelState.Clear();
                }
            }

            catch(Exception ex)
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
            return View(new RegisterEmployee.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

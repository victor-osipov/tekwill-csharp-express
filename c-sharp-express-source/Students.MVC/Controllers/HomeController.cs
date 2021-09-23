using System;
using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Students.Domain.Entity;
using Students.MVC.Models;

namespace Students.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// /home route
        /// </summary>
        public IActionResult Index()
        {
            // no custom logic. .

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Student([FromQuery] string first, string last)
        {
            var rand = new Random();

            var stud = new Student
            {
                FirstName = first,
                LastName = last,
                Id = rand.Next(),
                BirthDay = DateTime.Now,

            };

            return View(stud);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

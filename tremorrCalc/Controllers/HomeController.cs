using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tremorrCalc.Models;

namespace tremorrCalc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(calc asd)
        {
            int a, b;
            a = asd.number1;
            b = asd.number2;

            if(asd.calculate == "+") 
            {
                asd.result = a + b;
            }
            else if (asd.calculate == "-")
            {
                asd.result = a - b;
            }
            else if (asd.calculate == "*")
            {
                asd.result = a * b;
               
            }
            else if (asd.calculate == "^")
            {
                asd.result = (int)Math.Pow(a, b);
            }
            else if (asd.calculate == "||")
            {
                asd.result = a % b;
            }
            ViewData["result"] = asd.result;
            return View();
        }
        [HttpPost]
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
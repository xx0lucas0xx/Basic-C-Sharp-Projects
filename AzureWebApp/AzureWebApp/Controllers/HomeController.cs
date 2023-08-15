using AzureWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AzureWebApp.Controllers
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
            DateTime serverTime = DateTime.Now;
            string formattedTime = serverTime.ToString("yyy-MM-dd HH:mm:ss");

            ViewBag.ServerTime = formattedTime;


            return View();
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
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebCommercial.Models;

namespace WebCommercial.Controllers
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
            var id = BackgroundJob.Enqueue(() => PrintWithDelay("Hello", 10000000));
            BackgroundJob.ContinueWith(id, () => Console.WriteLine("world!"));
            return View();
        }
        public void PrintWithDelay(string text, int delayMs)
        {
            Thread.Sleep(delayMs);
            Console.WriteLine(text);
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

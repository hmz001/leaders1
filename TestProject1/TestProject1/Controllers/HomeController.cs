using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestProject1.Models;

namespace TestProject1.Controllers
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
        private ReactionResult ElementReaction(Element firstElement, Element secondElement)
        {
            var result = new ReactionResult();
            //do something
            //if success
            if (true)
            {
                result.Success = true;
                result.Result = "CO2";
            }
            else {
                result.Success = false;
                result.Result = "These elements do not react with eachother";
            }
            return result;
        }

        private ReactionResult ElementReaction( List<Element> elements)
        {
            var result = new ReactionResult();
            //do something
            //if success
            if (true)
            {
                result.Success = true;
                result.Result = "CO2";
            }
            else
            {
                result.Success = false;
                result.Result = "These elements do not react with eachother";
            }
            return result;
        }
    }
}

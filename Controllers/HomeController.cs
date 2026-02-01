using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            return View(new AnswersModel());
        }


        [HttpPost]
        public IActionResult Index(AnswersModel answers)
        {

            int incorrect = 0;      
           foreach (var item in answers.iscat)
            {
                if ((bool)item.Value[0] == true) //if we are dealing with a cat, check if it has been toggled,  if not, incorrect
                {
                    if (!answers.selected.Contains(item.Key))
                    {
                        incorrect++;
                    }
                }
                else if((bool)item.Value[0] == false) // dealing with a dog, check if it has been toggled, if so incorrect
                {
                    if (answers.selected.Contains(item.Key))
                    {
                        incorrect++;
                    }
                }
            }

            ViewData["Incorrect"] = incorrect;
            return View(answers);
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

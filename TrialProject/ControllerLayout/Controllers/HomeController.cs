using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tasks.Controllers.Repositories;
using Tasks.Models;
using TrialProject.Controllers.Repositories;
using TrialProject.Models;

namespace Tasks.Models
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        IRepository<Project> dbProject;

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

        public IActionResult ViewAllProject()
        {
            UnitOfWork db = new UnitOfWork();
            var technicalSpecification = db.TechnicalSpecification.GetItemList();
            return View(technicalSpecification);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
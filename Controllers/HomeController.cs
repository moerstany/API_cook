using System.Diagnostics;
using API_cook.Models;
using API_cook.Servises;
using Microsoft.AspNetCore.Mvc;

namespace API_cook.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CookApiService cookApiService;

        public HomeController(ILogger<HomeController> logger,CookApiService cookApiService)//добавили в контейнер сервис
        {
            _logger = logger;
            this.cookApiService = cookApiService;//создали поле для сервиса
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Search(string title)
        {
            var result = await cookApiService.SearchByTitle(title);// вызвали сервис поиска 
            ViewBag.Result = result;
            ViewBag.CookTitle = title;
            return View(result);

            
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
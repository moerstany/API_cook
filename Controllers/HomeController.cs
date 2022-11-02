using System.Diagnostics;
using API_cook.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_cook.Controllers
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

        public async Task<IActionResult> Search(string title)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://api.spoonacular.com/food/products/search/?apiKey=72d9d866960d4beab8ef876566b4782d&query={title}");
            var result= await response.Content.ReadAsStringAsync();
            ViewBag.Result=result;
            Console.WriteLine(result);

            ViewBag.CookTitle = title;  
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
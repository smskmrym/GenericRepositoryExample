using System.Diagnostics;
using GenericRepositoryExample.Core.Services;
using GenericRepositoryExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GenericRepositoryExample.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArtistService _artistService;
        private readonly IMusicService _musicService;

        public HomeController(ILogger<HomeController> logger, IArtistService artistService, IMusicService musicService)
        {
            _logger = logger;
            _artistService = artistService;
            _musicService = musicService;
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
    }
}

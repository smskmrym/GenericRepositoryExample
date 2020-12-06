using System.Collections.Generic;
using System.Threading.Tasks;
using GenericRepositoryExample.Core.Models;
using GenericRepositoryExample.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GenericRepositoryExample.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {
        private readonly ILogger<TestApiController> _logger;
        private readonly IMusicService _musicService;

        public TestApiController(ILogger<TestApiController> logger, IMusicService musicService)
        {
            _logger = logger;
            _musicService = musicService;
        }

        [HttpGet]
        public async Task<IEnumerable<Music>> GetMusics()
        {
            return await _musicService.GetAllMusics();
        }
    }
}
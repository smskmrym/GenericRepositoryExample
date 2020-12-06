using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using GenericRepositoryExample.Core.Models;
using GenericRepositoryExample.Core.Services;
using GenericRepositoryExample.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GenericRepositoryExample.Controllers.Api
{
    [Route("api/[controller]/")]
    [ApiController]
    public class MusicsController : ControllerBase
    {
        private readonly ILogger<MusicsController> _logger;
        private readonly IMusicService _musicService;
        private readonly IMapper _mapper;

        public MusicsController(ILogger<MusicsController> logger, IMusicService musicService, IMapper mapper)
        {
            _logger = logger;
            _musicService = musicService;
            _mapper = mapper;
        }

        // GET: api/Musics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MusicDto>>> Get()
        {
            //var musics = await _musicService.GetAllMusics();
            var musics = await _musicService.GetAllWithArtist();
            var dto = _mapper.Map<IEnumerable<Music>, IEnumerable<MusicDto>>(musics);

            return Ok(dto);
        }

        // GET: api/Musics/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<MusicDto>> GetAsync(int id)
        {
            var music = await _musicService.GetMusicById(id);
            MusicDto dto = _mapper.Map<Music, MusicDto>(music);
            return Ok(dto);
        }

        // POST: api/Musics
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Musics/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using GenericRepositoryExample.Core.Models;
using GenericRepositoryExample.Core.Services;
using GenericRepositoryExample.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GenericRepositoryExample.Controllers.Api
{
    //TODO: Logging process design with Serilog

    [Route("api/[controller]/")]
    [ApiController]
    public class MusicsController : ControllerBase
    {
        private readonly ILogger<MusicsController> _logger;
        private readonly IMusicService _musicService;
        private readonly IMapper _mapper;
        private readonly IValidator<SaveMusicDto> _validator;

        public MusicsController(ILogger<MusicsController> logger, IMusicService musicService, IMapper mapper, IValidator<SaveMusicDto> validator)
        {
            _logger = logger;
            _musicService = musicService;
            _mapper = mapper;
            _validator = validator;
        }

        // GET: api/Musics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MusicDto>>> GetAllMusic()
        {
            //var musics = await _musicService.GetAllMusics();
            var musics = await _musicService.GetAllWithArtist();
            var dto = _mapper.Map<IEnumerable<Music>, IEnumerable<MusicDto>>(musics);

            return Ok(dto);
        }

        // GET: api/Musics/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<MusicDto>> GetMusic(int id)
        {
            var music = await _musicService.GetMusicById(id);
            MusicDto dto = _mapper.Map<Music, MusicDto>(music);
            return Ok(dto);
        }

        // POST: api/Musics
        [HttpPost]
        public async Task<ActionResult<MusicDto>> CreateMusic([FromBody] SaveMusicDto musicResource)
        {
            var validation = await _validator.ValidateAsync(musicResource);

            if (!validation.IsValid)
                return BadRequest(validation.Errors);

            var music = _mapper.Map<SaveMusicDto, Music>(musicResource);
            var newMusic = await _musicService.CreateMusic(music);

            //optional
            newMusic = await _musicService.GetMusicById(newMusic.Id);

            return CreatedAtAction("CreateMusic", _mapper.Map<Music, MusicDto>(newMusic));
        }

        //TODO: Incomplete actions for update and delete

        // PUT: api/Musics/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

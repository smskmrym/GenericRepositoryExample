using AutoMapper;
using GenericRepositoryExample.Core.Models;
using GenericRepositoryExample.Models.Dto;

namespace GenericRepositoryExample.Models.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Music, MusicDto>();
            CreateMap<Artist, ArtistDto>();

            CreateMap<MusicDto, Music>();
            CreateMap<ArtistDto, Artist>();

            CreateMap<SaveMusicDto, Music>();
            CreateMap<SaveArtistDto, Artist>();

            CreateMap<Music, SaveMusicDto>();
            CreateMap<Artist, SaveArtistDto>();
        }
    }
}

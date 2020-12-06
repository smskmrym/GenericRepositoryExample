using System.Collections.Generic;
using System.Threading.Tasks;
using GenericRepositoryExample.Core.Models;

namespace GenericRepositoryExample.Core.Services
{
    public interface IMusicService //Crud Service
    {
        Task<IEnumerable<Music>> GetAllWithArtist();
        Task<IEnumerable<Music>> GetAllMusics();
        Task<Music> GetMusicById(int id);
        Task<IEnumerable<Music>> GetMusicsByArtistId(int artistId);
        Task<Music> CreateMusic(Music newMusic);
        Task UpdateMusic(Music musicToBeUpdated, Music music);
        Task DeleteMusic(Music music);
    }
}

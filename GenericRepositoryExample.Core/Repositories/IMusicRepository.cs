using System.Collections.Generic;
using System.Threading.Tasks;
using GenericRepositoryExample.Core.Models;

namespace GenericRepositoryExample.Core.Repositories
{
    public interface IMusicRepository : IRepository<Music>
    {
        Task<IEnumerable<Music>> GetAllWithArtistAsync();
        Task<IEnumerable<Music>> GetAllMusics();
        Task<Music> GetWithArtistByIdAsync(int id);
        Task<IEnumerable<Music>> GetAllWithArtistByArtistIdAsync(int artistId);
    }
}

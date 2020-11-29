using System.Collections.Generic;
using System.Threading.Tasks;
using GenericRepositoryExample.Core.Models;

namespace GenericRepositoryExample.Core.Services
{
    public interface IArtistService //Crud Service
    {
        Task<IEnumerable<Artist>> GetAllArtists();
        Task<Artist> GetArtistById(int id);
        Task<Artist> CreateArtist(Artist newArtist);
        Task UpdateArtist(Artist artistToBeUpdated, Artist artist);
        Task DeleteArtist(Artist artist);
    }
}

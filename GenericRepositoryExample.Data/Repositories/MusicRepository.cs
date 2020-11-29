using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericRepositoryExample.Core.Models;
using GenericRepositoryExample.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryExample.Data.Repositories
{
    public class MusicRepository : Repository<Music>, IMusicRepository
    {
        public MusicRepository(GenericRepoDbContext context) : base(context)
        {
        }

        private GenericRepoDbContext GenericRepoDbContext
        {
            get { return _context as GenericRepoDbContext; }
        }

        public async Task<IEnumerable<Music>> GetAllWithArtistAsync()
        {
            return await GenericRepoDbContext.Musics
                            .Include(m => m.Artist)
                            .ToListAsync();
        }

        public async Task<IEnumerable<Music>> GetAllWithArtistByArtistIdAsync(int artistId)
        {
            return await GenericRepoDbContext.Musics
                .Include(m => m.Artist)
                .Where(m => m.ArtistId == artistId)
                .ToListAsync();
        }

        public async Task<Music> GetWithArtistByIdAsync(int id)
        {
            return await GenericRepoDbContext.Musics
                                        .Include(m => m.Artist)
                                        .SingleOrDefaultAsync(m => m.Id == id);
        }
    }
}
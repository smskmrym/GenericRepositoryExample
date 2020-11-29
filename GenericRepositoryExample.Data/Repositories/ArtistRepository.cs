using System.Collections.Generic;
using System.Threading.Tasks;
using GenericRepositoryExample.Core.Models;
using GenericRepositoryExample.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryExample.Data.Repositories
{
    public class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        //private readonly GenericRepoDbContext genericRepoDbContext;

        public ArtistRepository(GenericRepoDbContext context) : base(context)
        {
            //genericRepoDbContext = context;
        }

        private GenericRepoDbContext GenericRepoDbContext
        {
            get { return _context as GenericRepoDbContext; }
        }
        
        public async Task<IEnumerable<Artist>> GetAllWithMusicsAsync()
        {
            return await GenericRepoDbContext.Artists
                .Include(a => a.Musics)
                .ToListAsync();
        }

        public Task<Artist> GetWithMusicsByIdAsync(int id)
        {
            return GenericRepoDbContext.Artists
                .Include(a => a.Musics)
                .SingleOrDefaultAsync(a => a.Id == id);
        }
    }
}

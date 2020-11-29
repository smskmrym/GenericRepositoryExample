using System.Threading.Tasks;
using GenericRepositoryExample.Core.Repositories;
using GenericRepositoryExample.Data.Repositories;

namespace GenericRepositoryExample.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(GenericRepoDbContext context)
        {
            _context = context;
        }

        private readonly GenericRepoDbContext _context;
        private MusicRepository _musicRepository;
        private ArtistRepository _artistRepository;

        public IMusicRepository Musics => _musicRepository ?? new MusicRepository(_context);
        public IArtistRepository Artists => _artistRepository ?? new ArtistRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            _musicRepository = null;
            _artistRepository = null;
        }
    }
}

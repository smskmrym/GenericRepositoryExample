using System;
using System.Threading.Tasks;

namespace GenericRepositoryExample.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IMusicRepository Musics { get; }
        IArtistRepository Artists { get; }

        Task<int> CommitAsync();
    }
}

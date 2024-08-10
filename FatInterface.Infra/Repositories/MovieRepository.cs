using FatInterface.Core.Entities;
using FatInterface.Core.Interfaces.Repositories;

namespace FatInterface.Infra.Repositories
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
    }
}

using FatInterface.Core.Entities;
using FatInterface.Core.Interfaces.Repositories;

namespace FatInterface.Infra.Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
    }
}

using FatInterface.Core.Entities;

namespace FatInterface.Core.Interfaces.Services
{
    public interface IPersonService
    {
        void CustomMethod(int id);
        void Update(Person entity);
        Person GetById(int id);
        IEnumerable<Person> GetAll();
    }
}

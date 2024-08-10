using FatInterface.Core.Entities;
using FatInterface.Core.Interfaces.Services;

namespace FatInterface.Core.Services
{
    public class PersonService : GenericService<Person>, IPersonService
    {
        public void CustomMethod(int id)
        {
            //Code to the CustomGet method. Just an example
        }
    }
}

using FatInterface.Core.Entities;
using FatInterface.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace FatInterface.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        public IEnumerable<Person> GetAllPerson()
        {
            return _personService.GetAll();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using curstomersApi.Persistence.Entitiy;
using curstomersApi.Service;

namespace curstomersApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // POST: api/Person
        [HttpPost]
        public IActionResult SavePerson([FromBody] Person person)
        {
            _personService.CreatePerson(person);

            return CreatedAtAction(nameof(GetPersonById), new { id = person.Id }, person);
        }

        // GET: api/Person
        [HttpGet]
        public IActionResult GetPersons()
        {
            var persons = _personService.GetPersons();
            return Ok(persons);
        }

        // GET: api/Person/5
        [HttpGet("{id}")]
        public IActionResult GetPersonById(Guid id)
        {
            var person = _personService.GetPersonById(id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        // PUT: api/Person/5
        [HttpPut("{id}")]
        public IActionResult UpdatePerson(Guid id, [FromBody] Person updatedPerson)
        {
            var existingPerson = _personService.GetPersonById(id);

            if (existingPerson == null) return NotFound();

            _personService.UpdatePerson(id, updatedPerson);

            return NoContent();
        }

        // DELETE: api/Person/5
        [HttpDelete("{id}")]
        public ActionResult DeletePerson(Guid id)
        {
            var existingPerson = _personService.GetPersonById(id);

            if (existingPerson == null) return NotFound();

            _personService.DeletePerson(id);
            return NoContent();
        }
    }
}

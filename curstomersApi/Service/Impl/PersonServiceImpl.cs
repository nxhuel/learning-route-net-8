using curstomersApi.Context;
using curstomersApi.Persistence.Entitiy;

namespace curstomersApi.Service.Impl
{
    public class PersonServiceImpl : IPersonService
    {
        private readonly AppDbContext _db;

        public PersonServiceImpl(AppDbContext db)
        {
            _db = db;
        }

        public void CreatePerson(Person person)
        {
            _db.Persons.Add(person);
            _db.SaveChanges();
        }

        public Person GetPersonById(Guid id) => _db.Persons.Find(id);

        public IEnumerable<Person> GetPersons() => _db.Persons;

        public void UpdatePerson(Guid id, Person updatedPerson)
        {
            var existingPerson = _db.Persons.Find(id);

            if (existingPerson == null) return ;

            existingPerson.Name = updatedPerson.Name;
            existingPerson.Age = updatedPerson.Age; 

            _db.SaveChanges();
        }

        public void DeletePerson(Guid id)
        {
            var person = _db.Persons.Find(id);
            if (person != null)
            {
                _db.Persons.Remove(person);
                _db.SaveChanges();
            }
        }
    }
}

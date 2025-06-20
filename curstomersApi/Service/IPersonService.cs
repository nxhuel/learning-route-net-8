using curstomersApi.Persistence.Entitiy;

namespace curstomersApi.Service
{
    public interface IPersonService
    {
        void CreatePerson(Person person);

        IEnumerable<Person> GetPersons();

        Person GetPersonById(Guid id);

        void UpdatePerson(Guid id, Person updatedPerson);

        void DeletePerson(Guid id);
    }
}

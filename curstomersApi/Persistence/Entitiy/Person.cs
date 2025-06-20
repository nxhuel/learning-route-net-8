using System.ComponentModel.DataAnnotations;

namespace curstomersApi.Persistence.Entitiy
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }
    }
}

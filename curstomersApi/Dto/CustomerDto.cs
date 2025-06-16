using System.ComponentModel.DataAnnotations;

namespace curstomersApi.Dtos
{
    public class CustomerDto
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "El email no es válido")]    
        public string Email { get; set; }

        [RegularExpression(@"^\+?\d{10,15}$", ErrorMessage = "Número invalido")]
        public string Phone { get; set; }

        public string Address { get; set; }
    }
}

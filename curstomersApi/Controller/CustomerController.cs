using curstomersApi.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace curstomersApi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("/api/[controller]")]
    public class CustomerController : Controller
    {
        [HttpPost]
        public async Task<CustomerDto> SaveCustomer(CustomerDto customerDto)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<List<CustomerDto>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type=typeof(CustomerDto))]
        public async Task<IActionResult> GetCustomerById(Guid id)
        {
            CustomerDto vacio = new CustomerDto();

            return new OkObjectResult(vacio);
        }

        [HttpPut("{id}")]
        public async Task<CustomerDto> UpdateCustomer(Guid id, CustomerDto customerDto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<string> DeleteCustomerById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

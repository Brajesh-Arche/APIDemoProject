using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiesLayer;
using DomainLayer;

namespace APIProjectDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServices _customerService;
        //public CustomerController(ICustomerServices cst)
        //{
        //    this._customerService = cst;
        //}
        public CustomerController(ICustomerServices customerService)
        {
           this._customerService = customerService;
        }
        [HttpGet(nameof(GetCustomer))]
        public IActionResult GetCustomer(int id)
        {
            var result = _customerService.GetCustomer(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No Records Found!!..");
        }
        [HttpGet(nameof(GetAllCustomer))]
        public IActionResult GetAllCustomer()
        {
            var result = _customerService.GetAllCustomer();
            if(result is not null)
            {
                return Ok(result);
            }
            return BadRequest("No Data Found!!.");
        }
        [HttpPost(nameof(InserCustomer))]
        public IActionResult InserCustomer(Customer customer)
        {
            _customerService.InsertCustomer(customer);
            return Ok("Data Inserted..");
        }
        [HttpPut(nameof(UpdateCustomer))]
        public IActionResult UpdateCustomer(DomainLayer.Customer customer)
        {
            _customerService.UpdateCustomer(customer);
            return Ok("Data Updated..");
        }
        [HttpDelete(nameof(DeleteCustomer))]
        public IActionResult DeleteCustomer(int id)
        {
            _customerService.DeleteCustomer(id);
            return Ok("Data Deleted..");
        }
    }
}

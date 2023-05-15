using BlazorSampleCrud.Core.Services.Interfaces;
using BlazorSampleCrud.DataAccessLayer.Entities.Common;
using BlazorSampleCrud.DataAccessLayer.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace BlazorSampleCrud.App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService customerService;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ICustomerService customerService , ILogger<CustomerController> logger)
        {
            this.customerService = customerService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {
            var result = await customerService.GetAllCustomer();
            return Ok(result);
        }

        [HttpPost]
        [Route("AddOrUpdate")]
        public async Task<IActionResult> Add_UpdateCustomer(Customer customer)
        {
            var status = new Status();
            if (!ModelState.IsValid)
            {
                status.StatusCode = 0;
                status.Succuss = false;
                status.StatusMessage = "Please Pass The Valid Data !!!";
                return Ok(status);
            }
            try
            {
                if (customer.Id == 0)
                {
                    await customerService.AddCustomer(customer);
                }
                else
                {
                    customerService.UpdateCustomer(customer);
                }
                await customerService.SaveChanges();
                status.StatusCode = 1;
                status.Succuss = false;
                status.StatusMessage = "Save Customer Successfully ...";
            }
            catch (Exception e)
            {
                status.StatusCode = 0;
                status.Succuss = false;
                status.StatusMessage = "Server error";
                _logger.LogError(e, "Badness");
                return BadRequest(-1);
            }
            return Ok(status);
        }



        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<Customer?> GetCustomerById(int Id)
        {
            return await customerService.GetCustomerById(Id);
        }


        [HttpDelete]
        [Route("DeleteById/{id}")]
        public async Task<IActionResult> DeleteCustomerById(int Id)
        {
            Status status = new();
            var customer = await customerService.GetCustomerById(Id);
            if (customer is null)
            {
                status.StatusCode = 0;
                status.Succuss = false;
                status.StatusMessage = "Customer Does Not Exist !!!";
            }
            await customerService.DeleteCustomerById(Id);
            await customerService.SaveChanges();
            status.StatusCode = 1;
            status.Succuss = true;
            status.StatusMessage = "Customer Delete Successfully ...";
            return Ok(customer);
        }

        [HttpDelete]
        [Route("Delete/{customer}")]
        public IActionResult DeleteCustomer([FromBody] Customer customer)
        {
            Status status = new();
            try
            {
                customerService.DeleteCustomer(customer);
                customerService.SaveChanges();
                status.StatusCode = 1;
                status.Succuss = true;
                status.StatusMessage = "Customer Delete Successfully ...";
                return Ok();
            }
            catch (Exception e)
            {
                status.StatusCode = 0;
                status.Succuss = false;
                status.StatusMessage = "Server error";
                _logger.LogError(e, "Badness");
                return BadRequest(-1);
            }
        }






    }
}

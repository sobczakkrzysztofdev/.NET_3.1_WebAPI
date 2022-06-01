using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.IServices;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customer)
        {
            customerService = customer;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/[controller]")]
        public List<CUSTOMER> GetCustomers()
        {
            return customerService.GetCustomers();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/[controller]/ById")]
        public CUSTOMER GetCustomerById(int id)
        {
            return customerService.GetCustomerById(id);
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/[controller]/add")]
        public CUSTOMER AddCustomer(CUSTOMER customer)
        {
            return customerService.AddCustomer(customer);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/[controller]/update")]
        public CUSTOMER UpdateCustomer(CUSTOMER customer)
        {
            return customerService.UpdateCustomer(customer);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/[controller]/delete")]
        public CUSTOMER DeleteCustomer(int id)
        {
            return customerService.DeleteCustomer(id);
        }

    }
}

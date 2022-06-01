using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.IServices
{
    public interface ICustomerService
    {
        List<CUSTOMER> GetCustomers();
        CUSTOMER GetCustomerById(int id);
        CUSTOMER AddCustomer(CUSTOMER customer);
        CUSTOMER UpdateCustomer(CUSTOMER customer);
        CUSTOMER DeleteCustomer(int id);

    }
}

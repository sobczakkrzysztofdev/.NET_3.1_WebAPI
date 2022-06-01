using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.IServices;
using WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Services
{
    public class CustomerService : ICustomerService
    {
        APICoreDBContext dbContext;

        public CustomerService(APICoreDBContext _db)
        {
            dbContext = _db;
        }

        public List<CUSTOMER> GetCustomers()
        {
            var customer = dbContext.CUSTOMER.ToList();
                return customer;
        }

        public CUSTOMER GetCustomerById(int id)
        {
            var customer = dbContext.CUSTOMER.FirstOrDefault(x => x.CUSTOMER_ID == id);
            return customer;
        }

        public CUSTOMER AddCustomer(CUSTOMER customer)
        {
            if(customer != null)
            {
                dbContext.CUSTOMER.Add(customer);
                dbContext.SaveChanges();
                return customer;
            }
            return null;
        }

        public CUSTOMER UpdateCustomer(CUSTOMER customer)
        {
            dbContext.Entry(customer).State = EntityState.Modified;
                dbContext.SaveChanges();
                return customer;
        }

        public CUSTOMER DeleteCustomer(int id)
        {
            var customer = dbContext.CUSTOMER.FirstOrDefault(x => x.CUSTOMER_ID == id);
            dbContext.Entry(customer).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return customer;
        }
    }
}

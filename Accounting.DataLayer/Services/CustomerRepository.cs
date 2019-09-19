using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Models;
using System.Data.Entity;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Accounting_DBEntities db ;
        public CustomerRepository(Accounting_DBEntities context)
        {
            ///dependency Injection ! (First solution)
           db = context;
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = db.Customers.Find(customerId);
                db.Customers.Remove(customer);
                return true;
            }
            catch
            {
                return false;
            }


        }

        public bool DeleteCustomer(Customer customer)
        {
            try
            {
                db.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }
        }

        public IEnumerable<Customer> FilterCustomer(string input)
        {
            return db.Customers.Where(a => a.Address.Contains(input) || a.Email.Contains(input) || a.FullName.Contains(input) || a.Mobile.Contains(input));
        }

        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customer GetCustomerById(int customerId)
        {
            var customer = db.Customers.Find(customerId);
            return customer;
        }

        public bool InsertCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}

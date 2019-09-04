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
        Accounting_DBEntities db = new Accounting_DBEntities();
        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = db.Customers.Find(customerId);
                db.Customers.Remove(customer);
                Save();
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
                Save();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public void Save()
        {
            db.SaveChanges();
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

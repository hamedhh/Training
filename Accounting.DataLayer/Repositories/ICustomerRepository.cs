﻿using Accounting.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        IEnumerable<Customer> FilterCustomer(string input);
        Customer GetCustomerById(int customerId);
        bool InsertCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        bool DeleteCustomer(int customerId);
    }
}

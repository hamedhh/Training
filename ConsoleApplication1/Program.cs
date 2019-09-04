using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using Accounting.DataLayer.Models;
using Accounting.DataLayer.Context;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //نباید این لایه دسترسی مستفیم به دیتابیس داشته باشد!!!!!!!!!!
            //Accounting_DBEntities db = new Accounting_DBEntities();
            //ICustomerRepository customer = new CustomerRepository();
            //Customer _customer = new Customer() {FullName="hamed",CustomerImage="NoPhoto",Mobile="00326556" };
            //customer.InsertCustomer(_customer);
            //customer.Save();

            //بنابراین برای استفاده از این کلاس باید الگوی یونیت اف ورک را پیاده سازی کرد!
            // این الگو جلوی دسترسی مستقیم به دیتابیس را میگیرد و آن را مستفیما به سرویس اون کلاس تزیق می گند

            UnitOfWork db = new UnitOfWork();

            var res =db.ICustomerrepository.GetAllCustomers();
            
            


        }
    }
}

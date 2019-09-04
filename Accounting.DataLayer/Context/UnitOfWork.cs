using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Models;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();

        private ICustomerRepository _IcustomerRepository { get; set; }

        public ICustomerRepository ICustomerrepository
        {
            get
            {
                if(_IcustomerRepository== null)
                {
                    return new CustomerRepository(db);
                }

                return _IcustomerRepository;
            }
        }


        public void Dispose()
        {
            db.Dispose();
        }
    }
}

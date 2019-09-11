using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Models;
using Accounting.DataLayer.Context;

namespace Accounting.App
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            BindGrid(); 
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                grdCustomer.DataSource= db.ICustomerrepository.GetAllCustomers().ToList();
            }//متد دیسپور یونیت آو ورک فراخوانی می شود!
        }
    }
}

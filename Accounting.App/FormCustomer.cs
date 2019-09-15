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
            grdCustomer.AutoGenerateColumns = false;
            BindGrid(); 
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                grdCustomer.DataSource= db.ICustomerrepository.GetAllCustomers().ToList();
            }//متد دیسپور یونیت آو ورک فراخوانی می شود!
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                grdCustomer.DataSource = db.ICustomerrepository.FilterCustomer(txtFilter.Text).ToList();
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            txtFilter.Text = null;
            BindGrid();
        }
    }
}

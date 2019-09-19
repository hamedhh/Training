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
using Accounting.App.Customers;

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
            UnitOfWork db = new UnitOfWork();
            grdCustomer.AutoGenerateColumns = false;
            BindGrid(); 
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                grdCustomer.DataSource= db.ICustomerrepository.GetAllCustomers().ToList();
                grdCustomer.Refresh();
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

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (grdCustomer.CurrentRow.Selected)
            {
                var customerId =int.Parse( grdCustomer.CurrentRow.Cells[3].Value.ToString());
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = grdCustomer.CurrentRow.Cells[0].Value.ToString();
                    if(RtlMessageBox.Show($"ایا از حذف {name}مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                                 var res = db.ICustomerrepository.DeleteCustomer(customerId);
                    db.SaveChange();
                    MessageBox.Show("عملیات حدف با موفقیت انجام شد");
                    BindGrid();
                    }
           
                }
            }
            else
                MessageBox.Show("مقداری انتخاب نشده است!");
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            FormAddOREditCustomer frmAddEdit = new FormAddOREditCustomer();
            frmAddEdit.ShowDialog();
        }
    }
}

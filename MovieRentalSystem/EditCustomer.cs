using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalSystem
{
    public partial class EditCustomer : Form
    {
        string Id;

        public EditCustomer()
        {
            InitializeComponent();
        }

        public EditCustomer(string CustomerId)
        {
            this.Id = CustomerId;
            DataTable dtCustomers = new DBContextHelper().GetCustomerByID(Id);
            InitializeComponent();
            tbx_FirstName.Text = dtCustomers.Rows[0]["CustomerFirstName"].ToString();
            tbx_LastName.Text = dtCustomers.Rows[0]["CustomerLastName"].ToString();
            tbx_Address.Text = dtCustomers.Rows[0]["CustomerAddress"].ToString();
            tbx_PhoneNo.Text = dtCustomers.Rows[0]["CustomerPhone"].ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbx_FirstName.Text == "" || tbx_LastName.Text == "" || tbx_Address.Text == "" || tbx_PhoneNo.Text == "")
            {
                MessageBox.Show("****Fill cumpulsory fields*****");
            }
            else
            {
                DBContextHelper database = new DBContextHelper();
                database.UpdateCustomer(tbx_FirstName.Text, tbx_LastName.Text, tbx_Address.Text, tbx_PhoneNo.Text, Id);
                MessageBox.Show("Customer Details Updated");
                Dispose();
            }
        }
    }
}

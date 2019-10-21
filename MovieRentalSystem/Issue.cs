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
    public partial class Issue : Form
    {
        private string Id;

        public Issue()
        {
            InitializeComponent();
        }

        public Issue(string IssueId)
        {
            this.Id = IssueId;
            InitializeComponent();
            tbx_MovieID.Text = Id;
        }

        private void Issue_Load(object sender, EventArgs e)
        {

        }

        private void CustID_TextChanged(object sender, EventArgs e)
        {
            tbx_FirstName.Text = "";
            tbx_LastName.Text = "";
            tbx_Address.Text = "";
            tbx_PhoneNo.Text = "";

            DataTable dtCustomers = new DBContextHelper().GetCustomerByID(tbx_CustomerID.Text);

            if (dtCustomers.Rows.Count > 0)
            {
                tbx_FirstName.Text = dtCustomers.Rows[0]["CustomerFirstName"].ToString();
                tbx_LastName.Text = dtCustomers.Rows[0]["CustomerLastName"].ToString();
                tbx_Address.Text = dtCustomers.Rows[0]["CustomerAddress"].ToString();
                tbx_PhoneNo.Text = dtCustomers.Rows[0]["CustomerPhone"].ToString();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbx_LastName.Text == "")
            {
                MessageBox.Show("Enter correct Customer ID");
            }
            else
            {
                string CurrentDate = DateTime.Now.ToString("MM/dd/yyyy") + " " + DateTime.Now.ToShortTimeString();
                DBContextHelper database = new DBContextHelper();
                database.Issue_Movie(Id, tbx_CustomerID.Text, CurrentDate);

                MessageBox.Show("Movie is Rented");
                Dispose();
            }
        }

        private void tbx_CustomerID_TextChanged(object sender, EventArgs e)
        {
            tbx_FirstName.Text = "";
            tbx_LastName.Text = "";
            tbx_Address.Text = "";
            tbx_PhoneNo.Text = "";

            DataTable dtCustomers = new DBContextHelper().GetCustomerByID(tbx_CustomerID.Text);

            if (dtCustomers.Rows.Count > 0)
            {
                tbx_FirstName.Text = dtCustomers.Rows[0]["CustomerFirstName"].ToString();
                tbx_LastName.Text = dtCustomers.Rows[0]["CustomerLastName"].ToString();
                tbx_Address.Text = dtCustomers.Rows[0]["CustomerAddress"].ToString();
                tbx_PhoneNo.Text = dtCustomers.Rows[0]["CustomerPhone"].ToString();
            }
        }
    }
}

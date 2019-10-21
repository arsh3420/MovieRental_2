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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            
            InitializeComponent();
        }


        void MethodToReuseDialogDisplay(Form o)
        {
            o.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MethodToReuseDialogDisplay(new Return());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MethodToReuseDialogDisplay(new Reports());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ALLHIDE()
        {
            logo.Visible = pnl_top10.Visible = pnl_return.Visible = pnl_viewmovie.Visible = pnl_customeradd.Visible = pnl_customerview.Visible = pnl_addmovie.Visible = false;
            // pnl_top10.Visible = pnl_return.Visible = pnl_viewmovie.Visible = pnl_customeradd.Visible = pnl_customerview.Visible = pnl_addmovie.Visible = false;
        }

        private void addcustomer_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "" || tb2.Text == "" || tb3.Text == "" || tb.Text == "")
            {
                MessageBox.Show("****Fill mandatory fields*****");
            }
            else
            {
                DBContextHelper database = new DBContextHelper();
                database.CreateCustomer(tb1.Text, tb2.Text, tb3.Text, tb.Text);
                MessageBox.Show("Customer Added");
                ALLHIDE();
            }
        }

        private void editToolStripMenuItemCustomer_Click(object sender, EventArgs e)
        {
            EditCustomer obj = new EditCustomer(gridcustomer.SelectedRows[0].Cells[0].Value.ToString());

            obj.ShowDialog();
            gridcustomer.DataSource = new DBContextHelper().GetAllCustomer();
        }

        private void addmovie_Click(object sender, EventArgs e)
        {
            int a, b;

            if (movie_title.Text == "" || movie_year.Text == "" || movie_rating.Text == "" || movie_copies.Text == "" || movie_plot.Text == "" || movie_gener.Text == "")
            {
                MessageBox.Show("****Fill mandatory fields*****");
            }
            else if (!int.TryParse(movie_year.Text, out a) || !(int.TryParse(movie_copies.Text, out b)))
            {
                MessageBox.Show("Year and Copies must be a correct value");
            }
            else
            {
                int rental = 0;
                if ((DateTime.Now.Year - a) > 5)
                {
                    rental = 2;
                }
                else
                {
                    rental = 5;
                }

                DBContextHelper database = new DBContextHelper();
                database.Create_Movie(movie_rating.Text, movie_title.Text, movie_year.Text, rental.ToString(), movie_copies.Text, movie_plot.Text, movie_gener.Text);

                MessageBox.Show("Movie Added");
                ALLHIDE();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMovie obj = new EditMovie(gridmovie.SelectedRows[0].Cells[0].Value.ToString());
            obj.ShowDialog();
            gridmovie.DataSource = new DBContextHelper().Get_All_Movies();
        }

        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int copies = new DBContextHelper().Check_Copies(Convert.ToInt32(gridmovie.SelectedRows[0].Cells[0].Value));
            if (copies > 0)
            {
                Issue issueRental = new Issue(gridmovie.SelectedRows[0].Cells[0].Value.ToString());
                issueRental.ShowDialog();
                gridmovie.DataSource = new DBContextHelper().Get_All_Movies();
            }
            else
            {
                MessageBox.Show("No copy available to rent");
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to reurn this rental?", "Return Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string Date = DateTime.Now.ToString("MM/dd/yyyy") + " " + DateTime.Now.ToShortTimeString();
                DBContextHelper database = new DBContextHelper();
                database.Return_Movie(Date, dataGridView1return.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("Movie Returned");

                dataGridView1return.DataSource = new DBContextHelper().Movies_ToBe_Returned();
            }
        }

        private void btn_addcustomer_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            pnl_customeradd.Visible = true;
        }

        private void btn_viewcustomer_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            pnl_customerview.Visible = true;
            gridcustomer.DataSource = new DBContextHelper().GetAllCustomer();
        }

        private void btn_addmovie_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            pnl_addmovie.Visible = true;
        }

        private void btn_viewmovie_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            pnl_viewmovie.Visible = true;
            gridmovie.DataSource = new DBContextHelper().Get_All_Movies();
        }

        private void btn_issuemovie_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            pnl_viewmovie.Visible = true;
            gridmovie.DataSource = new DBContextHelper().Get_All_Movies();
        }

        private void btn_returnmovie_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            pnl_return.Visible = true;
            dataGridView1return.DataSource = new DBContextHelper().Movies_ToBe_Returned();
        }

        private void btn_top10rec_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            pnl_top10.Visible = true;
            gridc.DataSource = new DBContextHelper().GetMostValuedCustomer();
            gridm.DataSource = new DBContextHelper().Get_Best_Sellers();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            ALLHIDE();
            logo.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int customerid = Convert.ToInt32(gridcustomer.SelectedRows[0].Cells[0].Value);
            if (customerid > 0)
            {
                new DBContextHelper().DeleteCustomer(customerid.ToString());
                gridcustomer.DataSource = new DBContextHelper().GetAllCustomer();
            }
            else
            {
                MessageBox.Show("No customer available to delete");
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int movieid = Convert.ToInt32(gridmovie.SelectedRows[0].Cells[0].Value);
            if (movieid > 0)
            {
                new DBContextHelper().DeleteMovie(movieid.ToString());
                gridmovie.DataSource = new DBContextHelper().Get_All_Movies();
            }
            else
            {
                MessageBox.Show("No movie available to delete");
            }
        }
    }
}

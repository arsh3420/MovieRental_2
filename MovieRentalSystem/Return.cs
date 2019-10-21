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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
            gv.DataSource = new DBContextHelper().Movies_ToBe_Returned();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rentalresult = MessageBox.Show("Are you sure to reurn this rental?", "Return Confirmation", MessageBoxButtons.YesNo);
            if (rentalresult == DialogResult.Yes)
            {
                string Date = DateTime.Now.ToString("MM/dd/yyyy") + " " + DateTime.Now.ToShortTimeString();
                DBContextHelper database = new DBContextHelper();
                database.Return_Movie(Date, gv.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("Movie Returned");

                gv.DataSource = new DBContextHelper().Movies_ToBe_Returned();
            }
        }
    }
}

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
    public partial class EditMovie : Form
    {
        string MovieId;
        public EditMovie()
        {
            InitializeComponent();
        }

        public EditMovie(string movId)
        {
            MovieId = movId;
            InitializeComponent();
            DataTable dtMovies = new DBContextHelper().Get_Movie_By_MovieID(movId);
            tbx_Rating.Text = dtMovies.Rows[0]["MoviesRatings"].ToString();
            tbx_Title.Text = dtMovies.Rows[0]["MoviesTitle"].ToString();
            tbx_Year.Text = dtMovies.Rows[0]["MoviesYear"].ToString();
            tbx_Copies.Text = dtMovies.Rows[0]["MoviesCopies"].ToString();
            tbx_Plot.Text = dtMovies.Rows[0]["MoviesPlot"].ToString();
            tbx_Genre.Text = dtMovies.Rows[0]["MoviesGenre"].ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int a, b;

            if (tbx_Rating.Text == "" || tbx_Title.Text == "" || tbx_Year.Text == "" || tbx_Copies.Text == "" || tbx_Plot.Text == "" || tbx_Genre.Text == "")
            {
                MessageBox.Show("****Fill compulsory fields*****");
            }
            else if (!int.TryParse(tbx_Year.Text, out a) || !(int.TryParse(tbx_Copies.Text, out b)))
            {
                MessageBox.Show("Year and Copies must have a correct value");
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
                database.Update_Movie(tbx_Rating.Text, tbx_Title.Text, tbx_Year.Text, rental.ToString(), tbx_Copies.Text, tbx_Plot.Text, tbx_Genre.Text, MovieId);
                MessageBox.Show("Movie Details Updated");
                Dispose();
            }
        }
    }
}

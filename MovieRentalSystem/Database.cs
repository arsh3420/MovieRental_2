using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace MovieRentalSystem
{
    public class DBContextHelper
    {
        protected SqlConnection _sqlConnection;
        protected SqlCommand _sqlCmd;
        protected SqlDataAdapter _sqlDAdapter;
        protected string _connString;

        public DBContextHelper()
        {
            _connString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            _sqlConnection = new SqlConnection(_connString);
        }

        public bool VerifyConnection()
        {
            bool Result = false;
            if (_sqlConnection.State != ConnectionState.Open)
            {
                _sqlConnection.Open();
            }
            Result = true;
            _sqlConnection.Close();
            return Result;
        }

        public void CreateCustomer(string firstname, string lastname, string address, string phone)
        {
            string Query = "INSERT INTO [Customer] VALUES (@CustomerFirstName, @CustomerLastName, @CustomerAddress, @CustomerPhone)";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            _sqlCmd.Parameters.AddWithValue("@CustomerFirstName", firstname);
            _sqlCmd.Parameters.AddWithValue("@CustomerLastName", lastname);
            _sqlCmd.Parameters.AddWithValue("@CustomerAddress", address);
            _sqlCmd.Parameters.AddWithValue("@CustomerPhone", phone);
            _sqlConnection.Open();
            _sqlCmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public void UpdateCustomer(string firstname, string lastname, string address, string phone, string customerid)
        {
            string Query = "UPDATE Customer SET [CustomerFirstName] = @CustomerFirstName, [CustomerLastName] = @CustomerLastName, [CustomerAddress] = @CustomerAddress, [CustomerPhone] = @CustomerPhone WHERE [CustomerID] = @CustomerID";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            _sqlCmd.Parameters.AddWithValue("@CustomerFirstName", firstname);
            _sqlCmd.Parameters.AddWithValue("@CustomerLastName", lastname);
            _sqlCmd.Parameters.AddWithValue("@CustomerAddress", address);
            _sqlCmd.Parameters.AddWithValue("@CustomerPhone", phone);
            _sqlCmd.Parameters.AddWithValue("@CustomerID", customerid);
            _sqlConnection.Open();
            _sqlCmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public void DeleteCustomer(string customerid)
        {
            string Query = "Delete from RentedMovies where RentedMovie_CID_FK=@CustomerID; DELETE FROM [Customer] WHERE [CustomerID] = @CustomerID";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            _sqlCmd.Parameters.AddWithValue("@CustomerID", customerid);
            _sqlConnection.Open();
            _sqlCmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public DataTable GetAllCustomer()
        {
            string Query = "SELECT * FROM [Customer]";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            DataTable table = new DataTable();
            _sqlDAdapter = new SqlDataAdapter(_sqlCmd);
            _sqlDAdapter.Fill(table);
            return table;
        }

        public DataTable GetCustomerByID(string id)
        {
            string Query = "SELECT * FROM [Customer] WHERE [CustomerID] = @CustomerID";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            _sqlCmd.Parameters.AddWithValue("@CustomerID", id);
            DataTable table = new DataTable();
            _sqlDAdapter = new SqlDataAdapter(_sqlCmd);
            _sqlDAdapter.Fill(table);
            return table;
        }

        public DataTable GetMostValuedCustomer()
        {
            string Query = "SELECT *, ISNULL((SELECT COUNT(RentedMovieID) FROM RentedMovies WHERE RentedMovie_CID_FK = Customer.CustomerID), 0) AS RentedMovies FROM Customer ORDER BY RentedMovies DESC";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            DataTable table = new DataTable();
            _sqlDAdapter = new SqlDataAdapter(_sqlCmd);
            _sqlDAdapter.Fill(table);
            return table;
        }

        public void Create_Movie(string MoviesRatings, string MoviesTitle, string MoviesYear, string MoviesRentalCost, string MoviesCopies, string MoviesPlot, string MoviesGenre)
        {
            string Query = "INSERT INTO [Movies] VALUES (@MoviesRatings, @MoviesTitle, @MoviesYear, @MoviesRental_Cost, @MoviesCopies, @MoviesPlot, @MoviesGenre)";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            _sqlCmd.Parameters.AddWithValue("@MoviesRatings", MoviesRatings);
            _sqlCmd.Parameters.AddWithValue("@MoviesTitle", MoviesTitle);
            _sqlCmd.Parameters.AddWithValue("@MoviesYear", MoviesYear);
            _sqlCmd.Parameters.AddWithValue("@MoviesRental_Cost", MoviesRentalCost);
            _sqlCmd.Parameters.AddWithValue("@MoviesCopies", MoviesCopies);
            _sqlCmd.Parameters.AddWithValue("@MoviesPlot", MoviesPlot);
            _sqlCmd.Parameters.AddWithValue("@MoviesGenre", MoviesGenre);
            _sqlConnection.Open();
            _sqlCmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public void Update_Movie(string MoviesRatings, string MoviesTitle, string MoviesYear, string MoviesRentalCost, string MoviesCopies, string MoviesPlot, string MoviesGenre, string moviesid)
        {
            string Query = "UPDATE [Movies] SET [MoviesRatings] = @MoviesRatings, [MoviesTitle] = @MoviesTitle, [MoviesYear] = @MoviesYear, [MoviesRentalCost] = @MoviesRentalCost, [MoviesCopies] = @MoviesCopies, [MoviesPlot] =  @MoviesPlot, [MoviesGenre] = @MoviesGenre WHERE [MoviesID] = @MoviesID";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            _sqlCmd.Parameters.AddWithValue("@MoviesRatings", MoviesRatings);
            _sqlCmd.Parameters.AddWithValue("@MoviesTitle", MoviesTitle);
            _sqlCmd.Parameters.AddWithValue("@MoviesYear", MoviesYear);
            _sqlCmd.Parameters.AddWithValue("@MoviesRental_Cost", MoviesRentalCost);
            _sqlCmd.Parameters.AddWithValue("@MoviesCopies", MoviesCopies);
            _sqlCmd.Parameters.AddWithValue("@MoviesPlot", MoviesPlot);
            _sqlCmd.Parameters.AddWithValue("@MoviesGenre", MoviesGenre);
            _sqlCmd.Parameters.AddWithValue("@MovieID", moviesid);
            _sqlConnection.Open();
            _sqlCmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public void DeleteMovie(string id)
        {
            string Query = "Delete from RentedMovies where RentedMovie_MID_FK=@MoviesID; DELETE FROM [Movies] WHERE [MoviesID] = @MoviesID";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            _sqlCmd.Parameters.AddWithValue("@MoviesID", id);
            _sqlConnection.Open();
            _sqlCmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public DataTable Get_All_Movies()
        {
            string Query = "SELECT * FROM [Movies]";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            DataTable table = new DataTable();
            _sqlDAdapter = new SqlDataAdapter(_sqlCmd);
            _sqlDAdapter.Fill(table);
            return table;
        }

        public DataTable Get_Movie_By_MovieID(string id)
        {
            string Query = "SELECT * FROM [Movies] WHERE [MoviesID] = @MoviesID";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            _sqlCmd.Parameters.AddWithValue("@MoviesID", id);
            DataTable table = new DataTable();
            _sqlDAdapter = new SqlDataAdapter(_sqlCmd);
            _sqlDAdapter.Fill(table);
            return table;
        }

        public DataTable Get_Best_Sellers()
        {
            string Query = "SELECT *, ISNULL((SELECT COUNT (RentedMovieID) FROM RentedMovies WHERE RentedMovie_MID_FK = Movies.MoviesID), 0) AS TimesRented FROM Movies ORDER BY TimesRented DESC";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            DataTable table = new DataTable();
            _sqlDAdapter = new SqlDataAdapter(_sqlCmd);
            _sqlDAdapter.Fill(table);
            return table;
        }

        public void Issue_Movie(string RentedMovie_MID_FK, string RentedMovie_CID_FK, string RentedMovie_DateRented)
        {
            string Query = "INSERT INTO [RentedMovies] (RentedMovie_MID_FK, RentedMovie_CID_FK, RentedMovie_DateRented) VALUES (@RentedMovie_MID_FK, @RentedMovie_CID_FK, @RentedMovie_DateRented)";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            _sqlCmd.Parameters.AddWithValue("@RMovie_MID_FK", RentedMovie_MID_FK);
            _sqlCmd.Parameters.AddWithValue("@RMovie_CID_FK", RentedMovie_CID_FK);
            _sqlCmd.Parameters.AddWithValue("@RMovie_DateRented", RentedMovie_DateRented);
            _sqlConnection.Open();
            _sqlCmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public void Return_Movie(string date, string id)
        {
            string Query = "UPDATE [RentedMovies] SET [RentedMovie_DateReturned] = @RentedMovie_DateReturned WHERE [RentedMovieID] = @RentedMovieID";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            _sqlCmd.Parameters.AddWithValue("@RentedMovie_DateReturned", date);
            _sqlCmd.Parameters.AddWithValue("@RentedMovieID", id);
            _sqlConnection.Open();
            _sqlCmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public int Check_Copies(int id)
        {
            string Query = "SELECT (SELECT MoviesCopies FROM Movies WHERE Movies.MoviesID = @MoviesID) - (SELECT ISNULL(COUNT(RentedMovie_MID_FK), 0) FROM RentedMovies WHERE RentedMovie_MID_FK = @MoviesID AND RentedMovie_DateReturned IS NULL)";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            _sqlCmd.Parameters.AddWithValue("@MoviesID", id);
            DataTable table = new DataTable();
            _sqlDAdapter = new SqlDataAdapter(_sqlCmd);
            _sqlDAdapter.Fill(table);
            return Convert.ToInt32(table.Rows[0][0]);
        }

        public DataTable Movies_ToBe_Returned()
        {
            string Query = "SELECT RentedMovies.RentedMovieID, Customer.CustomerFirstName, Customer.CustomerLastName, Customer.[CustomerAddress], Movies.MoviesTitle, Movies.MoviesRental_Cost, RentedMovies.RentedMovie_DateRented, RentedMovies.RentedMovie_DateReturned FROM RentedMovies INNER JOIN Movies ON RentedMovies.RentedMovie_MID_FK = Movies.MoviesID INNER JOIN Customer ON RentedMovies.RentedMovie_CID_FK = Customer.CustomerID WHERE RentedMovies.RentedMovie_DateReturned IS NULL";
            _sqlCmd = new SqlCommand(Query, _sqlConnection);
            DataTable table = new DataTable();
            _sqlDAdapter = new SqlDataAdapter(_sqlCmd);
            _sqlDAdapter.Fill(table);
            return table;
        }
    }
}

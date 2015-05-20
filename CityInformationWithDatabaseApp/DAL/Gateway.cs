using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityInformationWithDatabaseApp.Model;

namespace CityInformationWithDatabaseApp.DAL
{
    class Gateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionDb"].ConnectionString;

        public int Save(City aCity)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO tbl_city VALUES ('" + aCity.CityName + "', '" + aCity.About + "', '" + aCity.Country + "')";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();
            connection.Close();

            return rowAffected;
        }
    }
}

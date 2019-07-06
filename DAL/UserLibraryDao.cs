using Entities;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserLibraryDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public IEnumerable<UserLibraryBook> GetBooksByID(int Reader_ID)
        {
            List<UserLibraryBook> library = new List<UserLibraryBook>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetBooksByID";
                cmd.Parameters.AddWithValue("@Reader_ID", Reader_ID);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    library.Add(new UserLibraryBook
                    {
                        Ticket_ID = (int)reader["Ticket_ID"],
                        Author = (string)reader["Author"],
                        Title = (string)reader["Title"],
                        DaysBeforeReturn = (int)reader["DaysBeforeReturn"]
                    });
                }
            }
            return library;
        }
    }
}
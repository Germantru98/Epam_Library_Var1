using DAL.Interface;
using Entities;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ReaderDao : IReaderDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void Add(Reader reader)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddReader";
                cmd.Parameters.AddWithValue(@"Name", reader.Name);
                cmd.Parameters.AddWithValue(@"Surname", reader.Surname);
                cmd.Parameters.AddWithValue(@"Phone", reader.Phone);
                cmd.Parameters.AddWithValue(@"Login", reader.Login);
                cmd.Parameters.AddWithValue(@"Password", reader.Password);

                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Reader_ID",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Reader> GetAllReaders()
        {
            List<Reader> readers = new List<Reader>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllReaders";
                connection.Open();
                var scan = cmd.ExecuteReader();
                while (scan.Read())
                {
                    readers.Add(new Reader
                    {
                        Reader_ID = (int)scan["Reader_ID"],
                        Name = (string)scan["Name"],
                        Surname = (string)scan["Surname"],
                        Phone = (string)scan["Phone"]
                    });
                }
            }
            return readers;
        }

        public void Remove(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveReader";
                cmd.Parameters.AddWithValue(@"Reader_ID", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Reader reader)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateReader";
                cmd.Parameters.AddWithValue(@"Reader_ID", reader.Reader_ID);
                cmd.Parameters.AddWithValue(@"Name", reader.Name);
                cmd.Parameters.AddWithValue(@"Surname", reader.Surname);
                cmd.Parameters.AddWithValue(@"Phone", reader.Phone);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public string GetLogin(Reader reader)
        {
            var login = "";
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetLogin";
                cmd.Parameters.AddWithValue(@"Reader_ID", reader.Reader_ID);
                connection.Open();
                var scan = cmd.ExecuteReader();
                while (scan.Read())
                {
                    login = (string)scan["Login"];
                }
                return login;
            }
        }

        public string GetPassword(Reader reader)
        {
            var password = "";
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetPassword";
                cmd.Parameters.AddWithValue(@"Reader_ID", reader.Reader_ID);
                connection.Open();
                var scan = cmd.ExecuteReader();
                while (scan.Read())
                {
                    password = (string)scan["Password"];
                }
                return password;
            }
        }

        public void SetNewPassword(Reader reader, string newPassword)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SetNewPassword";
                cmd.Parameters.AddWithValue(@"Reader_ID", reader.Reader_ID);
                cmd.Parameters.AddWithValue(@"Password", newPassword);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void SetNewLogin(Reader reader, string newLogin)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SetNewLogin";
                cmd.Parameters.AddWithValue(@"Reader_ID", reader.Reader_ID);
                cmd.Parameters.AddWithValue(@"Login", newLogin);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool IsLoginExist(string login)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsLoginExist";
                cmd.Parameters.AddWithValue(@"Login", login);
                var num = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Result",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(num);
                connection.Open();
                cmd.ExecuteNonQuery();
                if ((int)num.Value == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string GetPasswordForLogin(string login)
        {
            var password = "";
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetPasswordForLogin";
                cmd.Parameters.AddWithValue(@"Login", login);
                connection.Open();
                var scan = cmd.ExecuteReader();
                while (scan.Read())
                {
                    password = (string)scan["Password"];
                }
                return password;
            }
        }
    }
}
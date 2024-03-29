﻿using DAL.Interface;
using Entities;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AuthorizationDao : IAuthorizationDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

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

        public bool IsPhoneExist(string phone)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IsPhoneExist";
                cmd.Parameters.AddWithValue(@"Phone", phone);
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
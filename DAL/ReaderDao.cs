﻿using DAL.Interface;
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
    }
}
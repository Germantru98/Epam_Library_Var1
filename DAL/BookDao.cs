using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BookDao : IBookDao
    {
        private string _connectionString = @"Data Source=TOP-PC\SQLEXPRESS;Initial Catalog = Library; Integrated Security = True";

        public void Add(Book book)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddBook";
                cmd.Parameters.AddWithValue(@"Title", book.Title);
                cmd.Parameters.AddWithValue(@"Author", book.Author);
                cmd.Parameters.AddWithValue(@"DateOfCreation", book.DateOfСreation);

                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@ID",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllBooks";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    books.Add(new Book
                    {
                        Book_ID = (int)reader["Book_ID"],
                        Title = (string)reader["Title"],
                        Author = (string)reader["Author"],
                        DateOfСreation = (DateTime)reader["DateOfCreation"]
                    });
                }
            }
            return books;
        }

        public void Remove(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveBook";
                cmd.Parameters.AddWithValue(@"ID", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Book book)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateBook";
                cmd.Parameters.AddWithValue(@"Book_ID", book.Book_ID);
                cmd.Parameters.AddWithValue(@"Title", book.Title);
                cmd.Parameters.AddWithValue(@"Author", book.Author);
                cmd.Parameters.AddWithValue(@"DateOfCreation", book.DateOfСreation);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
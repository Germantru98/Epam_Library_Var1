using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BookDao : IBookDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

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

        public IEnumerable<Book> GetBooksByTitle(string title)
        {
            List<Book> books = new List<Book>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetBooksByTitle";
                cmd.Parameters.AddWithValue("@Title", title);
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

        public IEnumerable<Book> GetBooksByAuthor(string author)
        {
            List<Book> books = new List<Book>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetBooksByAuthor";
                cmd.Parameters.AddWithValue("@Author", author);
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

        public IEnumerable<UserBook> GetBooksByID(int Reader_ID)
        {
            List<UserBook> library = new List<UserBook>();
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
                    library.Add(new UserBook
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
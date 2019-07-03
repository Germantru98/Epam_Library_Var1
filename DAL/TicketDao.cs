using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TicketDao : ITicketDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public void Add(Ticket ticket)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddTicket";
                cmd.Parameters.AddWithValue(@"Reader_ID", ticket.Reader_ID);
                cmd.Parameters.AddWithValue(@"Book_ID", ticket.Book_ID);
                cmd.Parameters.AddWithValue(@"StartDate", ticket.StartDate);
                cmd.Parameters.AddWithValue(@"EndDate", ticket.EndDate);
                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Ticket_ID",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            List<Ticket> ticket = new List<Ticket>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllTickets";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ticket.Add(new Ticket
                    {
                        Ticket_ID = (int)reader["Ticket_ID"],
                        Reader_ID = (int)reader["Reader_ID"],
                        Book_ID = (int)reader["Book_ID"],
                        StartDate = (DateTime)reader["StartDate"],
                        EndDate = (DateTime)reader["EndDate"],
                    });
                }
            }
            return ticket;
        }

        public void Remove(int ID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoveTicket";
                cmd.Parameters.AddWithValue(@"Ticket_ID", ID);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Ticket ticket)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateTicket";
                cmd.Parameters.AddWithValue(@"Ticket_ID", ticket.Ticket_ID);
                cmd.Parameters.AddWithValue(@"Reader_ID", ticket.Reader_ID);
                cmd.Parameters.AddWithValue(@"Book_ID", ticket.Book_ID);
                cmd.Parameters.AddWithValue(@"StartDate", ticket.StartDate);
                cmd.Parameters.AddWithValue(@"EndDate", ticket.EndDate);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
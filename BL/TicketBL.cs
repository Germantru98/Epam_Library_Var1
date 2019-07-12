using BL.Interface;
using DAL;
using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;

namespace BL
{
    public class TicketBL : ITicketBL
    {
        private ITicketDao ticketDao = new TicketDao();

        public void Add(Ticket ticket)
        {
            if (ticket.isCorrectState())
            {
                ticketDao.Add(ticket);
            }
            else
            {
                throw new ArgumentException("Error, Added book in incorrec state (empty fields)");
            }
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return ticketDao.GetAllTickets();
        }

        public void Remove(int ID)
        {
            if (ID > 0)
            {
                ticketDao.Remove(ID);
            }
            else
            {
                throw new ArgumentException("ID is negative or zero");
            }
        }

        public void Update(Ticket ticket)
        {
            if (ticket.isCorrectState())
            {
                ticketDao.Update(ticket);
            }
            else
            {
                throw new ArgumentException("Error, updated ticket in incorrec state (empty fields)");
            }
        }

        public Ticket GetTicketByID(int ticket_ID)
        {
            if (ticket_ID > 0)
            {
                return ticketDao.GetTicketByID(ticket_ID);
            }
            else
            {
                throw new ArgumentException("ticket_ID is negative or zero");
            }
           
        }
    }
}
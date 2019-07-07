﻿using BL.Interface;
using DAL;
using DAL.Interface;
using Entities;
using System.Collections.Generic;

namespace BL
{
    public class TicketBL : ITicketBL
    {
        private ITicketDao ticketDao = new TicketDao();

        public void Add(Ticket ticket)
        {
            ticketDao.Add(ticket);
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return ticketDao.GetAllTickets();
        }

        public void Remove(int ID)
        {
            ticketDao.Remove(ID);
        }

        public void Update(Ticket ticket)
        {
            ticketDao.Update(ticket);
        }

        public Ticket GetTicketByID(int ticketID)
        {
            return ticketDao.GetTicketByID(ticketID);
        }
    }
}
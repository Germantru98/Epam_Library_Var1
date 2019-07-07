using Entities;
using System.Collections.Generic;

namespace BL.Interface
{
    public interface ITicketBL
    {
        void Add(Ticket ticket);

        void Update(Ticket ticket);

        void Remove(int ID);

        Ticket GetTicketByID(int ticket_ID);

        IEnumerable<Ticket> GetAllTickets();
    }
}
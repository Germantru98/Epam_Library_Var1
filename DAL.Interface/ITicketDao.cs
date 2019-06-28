using Entities;
using System.Collections.Generic;

namespace DAL.Interface
{
    public interface ITicketDao
    {
        IEnumerable<Ticket> GetAllTickets();

        void Add(Ticket ticket);

        void Update(Ticket ticket);

        void Remove(int ID);
    }
}
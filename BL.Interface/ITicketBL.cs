using Entities;
using System.Collections.Generic;

namespace BL.Interface
{
    public interface ITicketBL
    {
        IEnumerable<Ticket> GetAllTickets();

        void Add(Ticket ticket);

        void Update(Ticket ticket);

        void Remove(int ID);
    }
}
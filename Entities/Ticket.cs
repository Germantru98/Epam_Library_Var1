using System;

namespace Entities
{
    public class Ticket
    {
        public int Ticket_ID { get; set; }
        public int Reader_ID { get; set; }
        public int Book_ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Ticket()
        { }

        public Ticket(int reader_ID, int book_ID, DateTime startDate, DateTime endDate)
        {
            Reader_ID = reader_ID;
            Book_ID = book_ID;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return $"{Ticket_ID}. Reader: {Reader_ID} Book: {Book_ID} Start: {StartDate} End: {EndDate}";
        }

        public bool isCorrectState()
        {
            if (Reader_ID <= 0 || Book_ID <= 0 || StartDate == null || EndDate == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
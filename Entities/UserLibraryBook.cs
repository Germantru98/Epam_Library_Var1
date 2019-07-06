namespace Entities
{
    public class UserLibraryBook
    {
        public int Ticket_ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int DaysBeforeReturn { get; set; }

        public UserLibraryBook()
        { }

        public UserLibraryBook(int ticket_ID, string title, string author, int days)
        {
            Ticket_ID = ticket_ID;
            Title = title;
            Author = author;
            DaysBeforeReturn = days;
        }

        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} Days before return: {DaysBeforeReturn}";
        }
    }
}
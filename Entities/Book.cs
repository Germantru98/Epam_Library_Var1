using System;

namespace Entities
{
    public class Book
    {
        public int Book_ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DateOfСreation { get; set; }

        public Book()
        { }

        public Book(string title, string author, DateTime dateOfCreation)
        {
            Title = title;
            Author = author;
            DateOfСreation = dateOfCreation;
        }

        public override string ToString()
        {
            return $"{Book_ID}. Title: \"{Title}\". Author: {Author}. Date of creation: {DateOfСreation.ToShortDateString()}";
        }
    }
}
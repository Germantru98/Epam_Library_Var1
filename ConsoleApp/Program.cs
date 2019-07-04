using BL;
using Entities;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ReaderBL rd = new ReaderBL();
            Reader r = new Reader("Rodion", "Gref", "89173238712");
            foreach (var i in rd.GetAllReaders())
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
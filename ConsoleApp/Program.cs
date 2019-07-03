using BL;
using Entities;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine();
            ReaderBL rd = new ReaderBL();
            foreach (var i in rd.GetAllReaders())
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
using DAL;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine();
            ReaderDao rd = new ReaderDao();
            foreach (var i in rd.GetAllReaders())
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
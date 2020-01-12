using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Book = new Book();
            Book.AddGrade(10.1);
            Book.AddGrade(20.1);

            Console.WriteLine(Book.GetAverage());
        }
    }
}

using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Lee's Book", 2.3);
            book.AddGrade(4.0);
            book.AddGrade(1.0);
            book.AddGrade(2.0);
            book.AddGrade(3.0);
            book.ShowGrade();
            book.ShowStatistics();

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]} !");
            }
            else
            {
                Console.WriteLine("Hello");
            }
        }
    }
}

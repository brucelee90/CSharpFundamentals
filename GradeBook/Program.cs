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

            var result = book.GetStatistics();

            System.Console.WriteLine($"The highest number is {result.High}");
            System.Console.WriteLine($"The lowest number is {result.Low}");
            System.Console.WriteLine($"The average number is {result.Average}");

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

using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Lee's Book", 50);

            // Loop

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }

            var result = book.GetStatistics();

            System.Console.WriteLine(Book.CATEGORY);
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

using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {

        static void OnGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("Grade was added");
        }
        static void Main(string[] args)
        {

            IBook book = new DiskBook("Lees_Book", 50);
            EnterGrades(book);

            /*
             * 
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

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

            */

            
        }

        private static void EnterGrades(IBook book)
        {
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
                    Console.WriteLine($"{grade} was added");
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

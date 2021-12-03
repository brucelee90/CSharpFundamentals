using System;
using System.Collections;
using System.Collections.Generic;

namespace GradeBook

{
    public class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name, double grade)
        {
            this.grades = new List<double>() { grade };
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public List<double> ShowGrade()
        {
            return this.grades;
        }

        public void ShowStatistics()
        {
            // var grades = new List<double>() { 1.1, 3.4, 5.0, 3.0 };

            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var result = 0.0;

            System.Console.WriteLine(highGrade);

            foreach (double grade in this.grades)
            {
                result += grade;
                lowGrade = Math.Min(grade, lowGrade);
                highGrade = Math.Max(grade, highGrade);

            }

            var averageResult = result /= grades.Count;

            System.Console.WriteLine($"The highest grade is {highGrade}, the lowest grade is {lowGrade} and the and the average is {averageResult}");

        }

    }
}
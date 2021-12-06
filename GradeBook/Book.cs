using System;
using System.Collections;
using System.Collections.Generic;

namespace GradeBook

{
    public class Book
    {
        private List<double> grades;
        public string Name;

        public Book(string name, double grade)
        {
            this.grades = new List<double>() { grade };
            Name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public List<double> ShowGrade()
        {
            return this.grades;
        }

        public Statistics GetStatistics()
        {
            // var grades = new List<double>() { 1.1, 3.4, 5.0, 3.0 };
            var statistic = new Statistics();
            var result = 0.0;

            statistic.High = double.MinValue;
            statistic.Low = double.MaxValue;

            foreach (double grade in this.grades)
            {
                result += grade;
                statistic.Low = Math.Min(grade, statistic.Low);
                statistic.High = Math.Max(grade, statistic.High);
            }

            statistic.Average = result /= grades.Count;

            return statistic;
        }

    }
}
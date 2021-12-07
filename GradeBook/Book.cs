using System;
using System.Collections;
using System.Collections.Generic;

namespace GradeBook

{
    public class Book
    {
        private List<double> grades;
        private string name;
        public string Name { get; set; }
        // const vars will always be static memebers of a class.
        public const string CATEGORY = "3";


        public Book(string name, double grade)
        {
            this.grades = new List<double>() { grade };
            Name = name;
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Unvalid {nameof(grade)}");
            }
        }

        public List<double> ShowGrade()
        {
            return this.grades;
        }

        public void AddGrade(char letter)
        {
            switch (letter)
            {

                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(60);
                    break;

                case 'E':
                    AddGrade(50);
                    break;

                case 'F':
                    AddGrade(40);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }

        public Statistics GetStatistics()
        {
            // var grades = new List<double>() { 1.1, 3.4, 5.0, 3.0 };
            var statistic = new Statistics();
            var index = 0;

            statistic.Average = 0.0;
            statistic.High = double.MinValue;
            statistic.Low = double.MaxValue;

            for (index = 0; index < grades.Count; index += 1)
            {
                statistic.Low = Math.Min(grades[index], statistic.Low);
                statistic.High = Math.Max(grades[index], statistic.High);
                statistic.Average += grades[index];
            };

            statistic.Average /= grades.Count;

            switch (statistic.Average)
            {

                case var d when d > 90.0:
                    statistic.Letter = 'A';
                    break;

                case var d when d > 80.0:
                    statistic.Letter = 'B';
                    break;

                case var d when d > 70.0:
                    statistic.Letter = 'C';
                    break;

                case var d when d > 60.0:
                    statistic.Letter = 'D';
                    break;

                case var d when d > 50.0:
                    statistic.Letter = 'E';
                    break;

                default:
                    statistic.Letter = 'F';
                    break;
            }

            return statistic;
        }

    }
}
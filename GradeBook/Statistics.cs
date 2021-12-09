using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Statistics
    {
        public double Average;
        public double Low;
        public double High;
        public double Letter;
        private List<double> Grades;
        

        public Statistics(List<double> grades)
        {
            Average = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
            Grades = grades;
        }

        private void CalculateLetterGrade()
        {
            switch (Average)
            {

                case var d when d > 90.0:
                    Letter = 'A';
                    break;

                case var d when d > 80.0:
                    Letter = 'B';
                    break;

                case var d when d > 70.0:
                    Letter = 'C';
                    break;

                case var d when d > 60.0:
                    Letter = 'D';
                    break;

                case var d when d > 50.0:
                    Letter = 'E';
                    break;

                default:
                    Letter = 'F';
                    break;
            }
        }

        public Statistics CalculateMinMaxAvg()
        {
            for (var index = 0; index < Grades.Count; index += 1)
            {
                Low = Math.Min(Grades[index], Low);
                High = Math.Max(Grades[index], High);
                Average += Grades[index];
            };

            Average /= Grades.Count;

            CalculateLetterGrade();

            return this;
        }
    }
}
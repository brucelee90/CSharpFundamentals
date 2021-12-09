using System;
using System.Collections.Generic;
using System.IO;
namespace GradeBook
{
    public class DiskBook : Book
    {
        private List<double> grades;
        public DiskBook(string name, double grade) : base(name, grade)
        {
            this.grades = new List<double>() { grade };
            Name = name;
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        {
            // open file, that has the same name as the book, with a .txt extension
            using (var writer = File.AppendText($"/Users/leeklopfers/Projects/{Name}.txt"))
            {
                writer.WriteLine(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
        }

        public override Statistics GetStatistics()
        {
            return new Statistics(grades).CalculateMinMaxAvg();
        }
    }
}

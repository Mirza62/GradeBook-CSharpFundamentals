using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    public class Book
    { 
        public Book(string _name)
        {
            Name = _name;
            grades = new List<double>();
        }

        public Statistics GetStatistics()
        {
            var results = new Statistics();
            results.Average = 0.0;
            results.High = double.MinValue;
            results.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                results.Low = Math.Min(grade, results.Low);
                results.High = Math.Max(grade, results.High);
                results.Average += grade ;
            }
            results.Average /= grades.Count;

            return results;
        }

        public List<double> grades;

        public string Name;

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}

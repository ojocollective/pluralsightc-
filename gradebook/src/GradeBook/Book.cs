using System;
using System.Collections.Generic;

namespace GradeBook
{
   public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            if( grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
        }

        public void ComputeStatistics()
        {
            highGrade = double.MinValue;
            lowGrade = double.MaxValue;
            foreach (var number in grades)
            {

               
                    highGrade = Math.Max(number, highGrade);
                    lowGrade = Math.Min(number, lowGrade);
                    result += number;
                    
               

            }
            result /= grades.Count;

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
                results.Average += grade;
            }

            results.Average = results.Average /= grades.Count;

            return results;

        }


       private List<double> grades;
       private string name;
       private double result;
       private double highGrade;
       private double lowGrade;

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Book
    {
        public Book()
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Double GetGrade(int Index)
        {
            return grades[Index];
        }
        public Double GetAverage()
        {
            double Sum = 0;
            foreach (double i in grades)
            {
                Sum += i;
            }
            return Sum/grades.Count;
        }


        List<Double> grades;
    }


}

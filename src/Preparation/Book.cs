using System.Collections.Generic;

namespace Preparation
{
    class Book
    {
        public Book(string name)
        {
            grade = new List<double>();
            this.name=name;
        }
        
        public void AddGrade(double x)
        {
            this.grade.Add(x);
        }

        private List<double> grade;
        private string name;
    }
}
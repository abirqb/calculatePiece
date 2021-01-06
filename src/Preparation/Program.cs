using System;
using System.Collections.Generic;

namespace Preparation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Abir!");

            var arr = new[] {11, 7 ,77 };
            var easy = new List<double>();
            easy.Add(12);
            easy.Add(2);

            foreach(var ab in easy)
            {
                System.Console.WriteLine(ab);
            }
            System.Console.WriteLine("\n\n");

            var book = new Book("Abir's Book");
            book.AddGrade(89.1);
            book.AddGrade(12);
        }
    }
}

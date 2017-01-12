using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Gradebook book = new Gradebook(); //constructor
            book.AddGrade(91);
            book.AddGrade(85.5f); //appending f allows float to be treated as a double

            //book = new Gradebook(); //wipes out previous instance of gradebook
            //book.AddGrade(60);

            Gradebook book2 = new Gradebook(); // new instance "book2"
            book2.AddGrade(75);

            Gradebook book3 = book; //creates a reference to original book, NOT A COPY
            book3.AddGrade(99);

            GradeStats stats = book.ComputeStats();
        }
    }
}

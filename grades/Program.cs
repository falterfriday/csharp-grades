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
        }
    }
}

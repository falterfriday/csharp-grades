using grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(90);
            book.AddGrade(80);
            book.AddGrade(70);
            book.AddGrade(60);
            book.AddGrade(50);

            GradeStats result = book.ComputeStats();
            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(90);
            book.AddGrade(80);
            book.AddGrade(70);
            book.AddGrade(60);
            book.AddGrade(50);

            GradeStats result = book.ComputeStats();
            Assert.AreEqual(50, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            Gradebook book = new Gradebook();
            book.AddGrade(90);
            book.AddGrade(80);
            book.AddGrade(70);
            book.AddGrade(60);
            book.AddGrade(50.5f); //double treated as a signle floating point

            GradeStats result = book.ComputeStats();
            Assert.AreEqual(70.1, result.AverageGrade, 0.1);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades.Types
{
    [TestClass]
    public class TypeTests
    {

        [TestMethod]
        public void ValueTypesPassedByValue()
        {
            int x = 46;

            IncrementNumber(x);
            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number) //this method creates a copy, not a reference
        {
            number += 1;
        }
        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            Gradebook book1 = new Gradebook();
            Gradebook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A Gradebook", book1.Name);
        }
        private void GiveBookAName(Gradebook book)
        {
            book.Name = "A Gradebook";
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Patrick";
            string name2 = "patrick";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IntVariablesHoldValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            //Assert.AreEqual(x1, x2); //test should fail
            Assert.AreNotEqual(x1, x2); //test should pass

        }

        [TestMethod]
        public void GradebookVariablesHoldAReference()
        {
            Gradebook g1 = new Gradebook(); //reference type (think ruby)
            Gradebook g2 = g1; //reference or pointer to g1, not a copy

            g1.Name = "Patrick's Gradebook";
            Assert.AreEqual(g1.Name, g2.Name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2017, 1, 16);
            date = date.AddDays(1); //reassign date
            Assert.AreEqual(17, date.Day);
        }

        [TestMethod]
        public void UppercaseAString()
        {
            string name = "patrick";
            name = name.ToUpper();
            Assert.AreEqual("PATRICK", name);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {

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
    }
}

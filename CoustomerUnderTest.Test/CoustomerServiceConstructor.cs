using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using NUnit.Framework.Legacy;
using NUnit.Framework;

namespace CoustomerUnderTest.Test
{
    [TestFixture(CustType.Premium)]
    public class CustomerServiceCosntructorDemo
    {
        private CustType testCustType;
        public CustomerServiceCosntructorDemo(CustType customerType)
        {
            this.testCustType = customerType;
        }
        [TestCase]
        public void TestMethod()
        {


            ClassicAssert.IsTrue(testCustType == CustType.Premium);
        }
    }
}

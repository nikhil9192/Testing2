using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace CoustomerUnderTest.Test
{
    [TestFixture]
    public class Class1
    {
        [TestCase]
        public void Test1()
        {
            Assert.That(1 == 1);
        }

        [Test]
        public void TestAccept()
        {
            Products p = new Products();
            p.ProductId = 1;
            p.ProductName = "SHIRT";
            p.Price = 1000;
            Products p1= new Products();
            p1.AcceptData(1, "SHIRT", 1000);
            ClassicAssert.AreEqual(p.ProductId, p1.ProductId);
            ClassicAssert.AreEqual(p.ProductName, p1.ProductName);
            ClassicAssert.AreEqual(p.Price, p1.Price);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using NUnit.Framework;

namespace CoustomerUnderTest.Test
{
    [TestFixture]
    public class CheckEmployeeAge
    {
        [TestCase(50)]
        [TestCase(4)]
        [TestCase(18)]
        public void WhenAdult_IsTrue(int age)
        {
            Emp emp = new Emp();
            emp.Age = age;

            bool result = emp.IsAdult();

            Assert.That(result == true);


        }
        }
    }

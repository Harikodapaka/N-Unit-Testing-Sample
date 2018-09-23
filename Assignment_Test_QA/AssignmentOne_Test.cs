using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment_QA;

namespace Assignment_Test_QA
{
    [TestFixture]
    public class AssignmentOne_Test
    {
        [Test]
        public void GetLength_SetLength3_ExpectedOutput3()
        {
            // Arrange
            int l= 3;
            int w = 5;
            Reactangle testReactangle = new Reactangle(l,w);
            // Act
            int length = testReactangle.GetLength();
            // Assert
            Assert.AreEqual(length,l);
        }
    }
}

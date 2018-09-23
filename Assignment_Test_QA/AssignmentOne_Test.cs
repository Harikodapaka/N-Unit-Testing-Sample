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
            Rectangle testReactangle = new Rectangle(l,w);
            // Act
            int length = testReactangle.GetLength();
            // Assert
            Assert.AreEqual(length,l);
        }
        [Test]
        public void GetWidth_SetWidth3_ExpectedOutput3()
        {
            // Arrange
            int l = 5;
            int w = 3;
            Rectangle testReactangle = new Rectangle(l, w);
            // Act
            int width = testReactangle.GetWidth();
            // Assert
            Assert.AreEqual(width, w);
        }
        [Test]
        public void SetLength_SetLength2_ExpectedOutput2()
        {
            // Arrange
            int l = 5;
            int w = 3;
            int expected_Length = 2;
            Rectangle testReactangle = new Rectangle(l, w);
            // Act
            int length = testReactangle.SetLength(expected_Length);
            // Assert
            Assert.AreEqual(length, expected_Length);
        }
        [Test]
        public void SetWidth_SetWidth5_ExpectedOutput5()
        {
            // Arrange
            int l = 2;
            int w = 3;
            int changed_Width = 5;
            Rectangle testReactangle = new Rectangle(l, w);
            // Act
            int width = testReactangle.SetWidth(changed_Width);
            // Assert
            Assert.AreEqual(width, changed_Width);
        }
        [Test]
        public void CalculatePerimeter_ExpectedOutput10()
        {
            // Arrange
            int l = 2;
            int w = 3;
            int expected_Perimeter = (2*l) + (2*w);
            Rectangle testReactangle = new Rectangle(l, w);
            // Act
            int perimeter = testReactangle.GetPerimeter();
            // Assert
            Assert.AreEqual(perimeter, expected_Perimeter);
        }
        [Test]
        public void CalculateArea_ExpectedOutput6()
        {
            // Arrange
            int l = 2;
            int w = 3;
            int expected_Area = l * w;
            Rectangle testReactangle = new Rectangle(l, w);
            // Act
            int area = testReactangle.GetArea();
            // Assert
            Assert.AreEqual(area, expected_Area);
        }
    }
}

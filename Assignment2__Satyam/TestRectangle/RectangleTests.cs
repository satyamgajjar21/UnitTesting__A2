using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment2__Satyam;

namespace RectangleTests
{
        [TestFixture]
        public class RectangleTest
        {
        //Test 1
            [Test]
            public void GetLength_Default_Returns1()
            {
                //Arrange
                int lenght = 1;
                Rectangle rect = new Rectangle();

                //Act
                int actual = rect.GetLength();

                //Assert
                Assert.AreEqual(lenght, actual);
            }

        //Test 2
        [Test]
        public void GetLength_Parameters_ReturnsWithParameter()
        {
            //Arrange
            int length = 10;
            int width = 20;

            int lengthExpected = 10;
            Rectangle rect = new Rectangle(length,width);

            //Act
            int lengthActual = rect.GetLength();

            //Assert
            Assert.AreEqual(lengthExpected, lengthActual);
        }

        //Test 3
        [Test]
        public void GetLength_negativeParameters_positiveReturns()
        {
            //Arrange
            int lenght = -10;
            int width = 20;

            int lengthExpected = -10;
            Rectangle rect = new Rectangle(lenght, width);

            //Act
            int lengthActual = rect.GetLength();

            //Assert
            Assert.AreEqual(lengthExpected, lengthActual);
        }

        //Test 4
        [Test]
        public void SetLength_input12_returns12()
        {
            //Arrange
            int lenght = 12;
            int resultExpected = 12;

            Rectangle rect = new Rectangle();

            //Act
            int resultActual = rect.SetLength(lenght);

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }


        //Test 5
        [Test]
        public void SetLength_inputless1_returnsException()
        {
            //Arrange
            int lenght = 0;

            //Act
            Rectangle rect = new Rectangle();

            //Assert
            Assert.Throws<Exception>(() => rect.SetLength(lenght));
        }


        //Test 6
        [Test]
        public void SetLength_overWrite_Length()
        {
            //Arrange
            int lenght = 15;
            int width = 16;

            Rectangle rect = new Rectangle(lenght,width);
            int newLength = 19;
            rect.SetLength(newLength);

            //Act
            int resultActual = rect.GetLength();

            //Assert
            Assert.AreEqual(newLength, resultActual);
        }


        //Test 7
        [Test]
        public void GetWidth_Default_returns1()
        {
            //Arrange
            int width = 1;
            Rectangle rect = new Rectangle();

            //Act
            int resultActual = rect.GetWidth();

            //Assert
            Assert.AreEqual(width, resultActual);
        }

        //Test 8
        [Test]
        public void GetWidth_Parameters_ReturnsWithParameter()
        {
            //Arrange
            int length = 10;
            int width = 20;

            int widthExpected = 20;
            Rectangle rect = new Rectangle(length, width);

            //Act
            int widthActual = rect.GetWidth();

            //Assert
            Assert.AreEqual(widthExpected, widthActual);
        }

        //Test 9
        [Test]
        public void GetWidth_negativeParameters_positiveReturns()
        {
            //Arrange
            int lenght = 10;
            int width = -20;

            int widthExpected = -20;
            Rectangle rect = new Rectangle(lenght, width);

            //Act
            int widthActual = rect.GetWidth();

            //Assert
            Assert.AreEqual(widthExpected, widthActual);
        }

        //Test 10
        [Test]
        public void SetWidth_input12_returns12()
        {
            //Arrange
            int width = 12;
            int resultExpected = 12;

            Rectangle rect = new Rectangle();

            //Act
            int resultActual = rect.SetWidth(width);

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }


        //Test 11
        [Test]
        public void GetWidth_inputless1_returnsException()
        {
            //Arrange
            int width = 0;

            //Act
            Rectangle rect = new Rectangle();

            //Assert
            Assert.Throws<Exception>(() => rect.SetWidth(width));
        }



        //Test 12
        [Test]
        public void SetWidth_overWrite_Width()
        {
            //Arrange
            int lenght = 15;
            int width = 16;

            Rectangle rect = new Rectangle(lenght, width);
            int newWidth = 16;
            rect.SetLength(newWidth);

            //Act
            int resultActual = rect.GetWidth();

            //Assert
            Assert.AreEqual(newWidth, resultActual);
        }


        //Test 13
        [Test]
        public void GetPerimeter_input3and4_returns14()
        {
            //Arrange
            int lenght = 15;
            int width = 16;

            int resultExpected = 62;

            Rectangle rect = new Rectangle(lenght, width);
           

            //Act
            int resultActual = rect.GetPerimeter();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }


        //Test 14
        [Test]
        public void GetPerimeter_inputNegativeValues_returnsPositiveValues()
        {
            //Arrange
            int lenght = -5;
            int width = -2;

            int resultExpected = -14;

            Rectangle rect = new Rectangle(lenght, width);


            //Act
            int resultActual = rect.GetPerimeter();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }

        //Test 15
        [Test]
        public void GetPerimeter_input0_throwsException()
        {
            //Arrange
            int lenght = 0;
            int width = 0;

            //Act
            Rectangle rect = new Rectangle(lenght, width);

       

            //Assert
            Assert.Throws<Exception>(() => rect.GetPerimeter());
        }

        //Test 16
        [Test]
        public void GetArea_input3and5_Returns15()
        {
            //Arrange
            int length = 5;
            int width = 3;

            int lengthExpected = 5;

            Rectangle rect = new Rectangle(length, width);

            //Act
            int lengthActual = rect.GetLength();

            //Assert
            Assert.AreEqual(lengthExpected, lengthActual);
        }


        //Test 17
        [Test]
        public void GetArea_negativeParameters_positiveReturns()
        {
            //Arrange
            int lenght = -10;
            int width = -8;

            int resultExpected = 80;

            Rectangle rect = new Rectangle(lenght, width);

            //Act
            int resultActual = rect.GetArea();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }


        //Test 18
        [Test]
        public void GetArea_input0_throwsException()
        {
            //Arrange
            int lenght = 0;
            int width = 0;

            //Act
            Rectangle rect = new Rectangle(lenght, width);

            //Assert
            Assert.Throws<Exception>(() => rect.GetArea());
        }
    }
}


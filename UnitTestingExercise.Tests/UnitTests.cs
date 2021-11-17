using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,1,2, 4)]
        [InlineData(4, 4, 8, 16)]
        [InlineData(5, 15, 20, 40)]
        public void Add(int num1, int num2,int num3, int expected) //this is part of the test method, not the method we are testing.
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            int actual = test.Add3(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,2,2)]
        [InlineData(10, 5, 5)]
        [InlineData(100, 63, 37)]
        [InlineData(52, 14, 38)]
        [InlineData(4, 1, 3)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(4, 4, 16)]
        [InlineData(5, 5, 25)]
        [InlineData(10, 10, 100)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(100, 10, 10)]
        [InlineData(25, 5, 5)]
        [InlineData(8, 4, 2)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void String()
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.GetString("x");
            //Assert
            Assert.Equal("x",actual);
        }

        [Fact]
        public void Integer()
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Getint(5);
            //Assert
            Assert.Equal(5, actual);
        }
    }
}

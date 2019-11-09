using HWork6;
using NUnit.Framework;
using System;

namespace Tests
{
    public class SingleDimentionMatrixOperationsTests
    {       
        [Test]
        public void AddingTwoMatrixes_GetMatrixSum()
        {
            //Arrange
            int[] firstArray = new [] {4, 3, -2 };
            var firstMatrix = new SmartMatrix(firstArray);
            int[] secondArray = new [] {2, 5, 3 };
            var secondMatrix = new SmartMatrix(secondArray);

            int[] arraySum = new[] { 6, 8, 1 };
            var expectedMatrix = new SmartMatrix(arraySum);

            //Act
            var result = firstMatrix + secondMatrix;

            //Assert
            Assert.AreEqual(expectedMatrix, result);
        }

        [Test]
        public void SubstractingTwoMatrixes_GetMatrixSubstraction()
        {
            //Arrange
            int[] firstArray = new[] { 4, 3, -2 };
            var firstMatrix = new SmartMatrix(firstArray);
            int[] secondArray = new[] { 2, 5, 3 };
            var secondMatrix = new SmartMatrix(secondArray);

            int[] arraySubstraction = new[] { 2, -2, -5 };
            var expectedMatrix = new SmartMatrix(arraySubstraction);

            //Act
            var result = firstMatrix - secondMatrix;

            //Assert
            Assert.AreEqual(expectedMatrix, result);
        }

        [Test]
        public void MultiplyingTwoMatrixes_GetMatrixMultiplication()
        {
            //Arrange
            int[] firstArray = new[] { 4, 3, -2 };
            var firstMatrix = new SmartMatrix(firstArray);
            int[] secondArray = new[] { 2, 5, 3 };
            var secondMatrix = new SmartMatrix(secondArray);

            var expectedInt = 17;

            //Act
            var result = firstMatrix * secondMatrix;

            //Assert
            Assert.AreEqual(expectedInt, result);
        }

        [Test]
        public void ThrowException()
        {
            //Arrange
            int[] firstArray = new[] { 4, 3, -2, 1 };
            var firstMatrix = new SmartMatrix(firstArray);
            int[] secondArray = new[] { 2, 5, 3 };
            var secondMatrix = new SmartMatrix(secondArray);

            int[] arraySum = new[] { 6, 8, 1 };
            var expectedMatrix = new SmartMatrix(arraySum);

            //Act
            Assert.Throws<ArgumentException>(() => { var result = firstMatrix + secondMatrix; });


        }
    }

}
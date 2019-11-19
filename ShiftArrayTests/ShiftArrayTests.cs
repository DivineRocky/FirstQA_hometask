using HomeWork2;
using NUnit.Framework;

namespace Tests
{
    public class ShiftArrayTests
    {
        [TestCase(0, 0, 5)]
        [TestCase(-5, -5, 0)]
        [TestCase(5, 5, 10)]
        public void CreateArrayWith5Elements_ShiftWorksAtNegativeAndPoxitive(int shift, int loverBound, int upperBound)
        {
            //Arrange

            //Act
            var array = new ShiftIndexArray<int>(shift, 5);

            //Assert
            Assert.AreEqual(loverBound, array.GetLowerBound);
            Assert.AreEqual(upperBound, array.GetUpperBound);
            Assert.AreEqual(5, array.GetLength);
        }

        [TestCase(0)]
        [TestCase(-2)]
        [TestCase(2)]
        public void SaveElement(int shift)
        {
            //Arrange
            var array = new ShiftIndexArray<int>(5, 5);
            var valueToAdd = 29;
            var elementIdnex = shift + 1;

            //Act
            array[elementIdnex] = valueToAdd;
            var savedElement = array[elementIdnex];

            //Assert
            Assert.AreEqual(valueToAdd, elementIdnex);
        }
    }
}
using StringLibrary;
namespace CalculatorMsUnitTests;

[TestClass]
public class MultiplyLogicUnitTest
{
  [TestMethod]
        public void Multiply_PositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var num1 = 5.5m;
            var num2 = 2.0m;

            // Act
            var result = Calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual("11", result); // Expected result: 5.5 * 2 = 11
        }

        [TestMethod]
        public void Multiply_NegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var num1 = -3.0m;
            var num2 = 4.5m;

            // Act
            var result = Calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual("-13.5", result); // Expected result: -3 * 4.5 = -13.5
        }

        [TestMethod]
        public void Multiply_Zero_ReturnsZero()
        {
            // Arrange
            var num1 = 0m;
            var num2 = 7.8m;

            // Act
            var result = Calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual("0", result); // Expected result: 0 * 7.8 = 0
        }
        

        [TestMethod]
        public void Multiply_Zero_ReturnsZero()
        {
            // Arrange
            var num1 = 0m;
            var num2 = 7.8m;

            // Act
            var result = Calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual("0", result); // Expected result: 0 * 7.8 = 0
        }

        [TestMethod]
        public void Multiply_DecimalNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var num1 = 2.5m;
            var num2 = 3.2m;

            // Act
            var result = Calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual("8", result); // Expected result: 2.5 * 3.2 = 8
        }

}
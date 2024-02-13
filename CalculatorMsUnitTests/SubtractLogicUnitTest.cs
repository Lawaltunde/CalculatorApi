using StringLibrary;
namespace CalculatorMsUnitTests;

[TestClass]
public class SubtractLogicUnitTest
{
    [TestMethod]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        var firstNumber = 8;
        var secondNumber = 3;
        var result = Calculator.Subtract(firstNumber, secondNumber);
       Assert.AreEqual(11, result);
    }

    [TestMethod]
    public void Subtract_NegativeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        var num1 = -8.7M;
        var num2 = -2.3M;

        // Act
        var result = Calculator.Subtract(num1, num2);

        // Assert
        Assert.AreEqual("-6.4", result);
    }

    [TestMethod]
    public void Subtract_ZeroFromPositiveNumber_ReturnsCorrectResult()
    {
        // Arrange
        var num1 = 15.0M;
        var num2 = 0.0M;

        // Act
        var result = Calculator.Subtract(num1, num2);

        // Assert
        Assert.AreEqual("15.0", result);
    }

    [TestMethod]
    public void Subtract_ZeroFromNegativeNumber_ReturnsCorrectResult()
    {
        // Arrange
        var num1 = -5.8M;
        var num2 = 0.0M;

        // Act
        var result = Calculator.Subtract(num1, num2);

        // Assert
        Assert.AreEqual("-5.8", result);
    }

    [TestMethod]
    public void Subtract_LargeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        var num1 = 1000000.123M;
        var num2 = 999999.987M;

        // Act
        var result = Calculator.Subtract(num1, num2);

        // Assert
        Assert.AreEqual("0.136", result);
    }


}
using StringLibrary;
namespace CalculatorMsUnitTests;

[TestClass]
public class DivideLogicUnitTest
{
    [TestMethod]
    public void Divide_PositiveNumbers_ReturnsCorrectResult()
    {
        // Arrange
        var num1 = 10.0M;
        var num2 = 2.0M;

        // Act
        var result = Calculator.Divide(num1, num2);

        // Assert
        Assert.AreEqual("5.0", result);
    }

    [TestMethod]
    public void Divide_NegativeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        var num1 = -15.0M;
        var num2 = -3.0M;

        // Act
        var result = Calculator.Divide(num1, num2);

        // Assert
        Assert.AreEqual("5.0", result);
    }

    [TestMethod]
    public void Divide_DenominatorZero_ReturnsInfinityMessage()
    {
        // Arrange
        var num1 = 8.0M;
        var num2 = 0.0M;

        // Act
        var result = Calculator.Divide(num1, num2);

        // Assert
        Assert.AreEqual("Infinity: Denominator cannot be zero!!!", result);
    }

    [TestMethod]
    public void Divide_ZeroNumerator_ReturnsZero()
    {
        // Arrange
        var num1 = 0.0M;
        var num2 = 5.0M;

        // Act
        var result = Calculator.Divide(num1, num2);

        // Assert
        Assert.AreEqual("0.0", result);
    }

    [TestMethod]
    public void Divide_LargeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        var num1 = 1000000.0M;
        var num2 = 500000.0M;

        // Act
        var result = Calculator.Divide(num1, num2);

        // Assert
        Assert.AreEqual("2.0", result);
    }
}
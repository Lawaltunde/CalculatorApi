using StringLibrary;
namespace CalculatorMsUnitTests;

[TestClass]
public class AddLogicUnitTest
{
    [TestMethod]
    public void AddShouldReturnCorrectSum()
    {
        var firstNumber = 5.0M;
        var secondNumber = 7.0M;
        var result = Calculator.Add(firstNumber, secondNumber);
       Assert.IsTrue(result, $"The result of {result} should have been false for sum of {firstNumber} and {secondNumber}");
    }

    [TestMethod]
    public void WhenBothValuesAreNegativesReturnShouldBeNegative()
    {
        var firstNumber = -9M;
        var secondNumber = -15M;
        var result = Calculator.Add(firstNumber, secondNumber);
       Assert.AreEqual(-24, result);
    }

    [TestMethod]
    public void ZeroesShouldReturnedWhenNoValueIsProvided()
    {
        decimal firstNumber;
        decimal secondNumber;
        decimal result = Calculator.Add(firstNumber, secondNumber);
       Assert.IsTrue(result, $"The result of {result} should have been false for sum of {firstNumber} and {secondNumber}");
    }

    [TestMethod]
    public void Add_ShouldHandleNegativeNumbers()
    {
        var firstNumber = -5.00M;
        var secondNumber = 7.00M;
        var result = Calculator.Add(firstNumber, secondNumber);
       Assert.IsTrue(2, result);
    }

    [TestMethod]
    public void Add_ShouldReturnCorrectAnswerWhenPassedValuesAreDecimals()
    {
        var firstNumber = 5.98M;
        var secondNumber = 7.98M;
        var result = Calculator.Add(firstNumber, secondNumber);
       Assert.IsTrue(result, $"The result of {result} should have been false for sum of {firstNumber} and {secondNumber}");
    }
}
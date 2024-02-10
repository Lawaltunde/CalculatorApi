using MyApp.Namespace;
using StringLibrary;
namespace CalculatorMsUnitTests;

[TestClass]
public class AddLogicUnitTest
{
    [TestMethod]
    public void AddShouldReturnCorrectSum()
    {
        var firstNumber = 5;
        var secondNumber = 7;
        var result = Calculator.Add(firstNumber, secondNumber);
       Assert.IsTrue(result, $"The result of {result} should have been false for sum of {firstNumber} and {secondNumber}");
    }

    [TestMethod]
    public void WhenBothValuesAreZeroesReturnShouldBeZero()
    {
        var firstNumber = 0;
        var secondNumber = 0;
        var result = Calculator.Add(firstNumber, secondNumber);
       Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void ZeroesShouldReturnedWhenNoValueIsProvided()
    {
        var firstNumber;
        var secondNumber;
        var result = Calculator.Add(firstNumber, secondNumber);
       Assert.IsTrue(result, $"The result of {result} should have been false for sum of {firstNumber} and {secondNumber}");
    }

    [TestMethod]
    public void Add_ShouldHandleNegativeNumbers()
    {
        var firstNumber = -5;
        var secondNumber = 7;
        var result = Calculator.Add(firstNumber, secondNumber);
       Assert.IsTrue(2, result);
    }

    [TestMethod]
    public void Add_ShouldReturnCorrectAnswerWhenPassedValuesAreDecimals()
    {
        var firstNumber = 5.98;
        var secondNumber = 7.98;
        var result = Calculator.Add(firstNumber, secondNumber);
       Assert.IsTrue(result, $"The result of {result} should have been false for sum of {firstNumber} and {secondNumber}");
    }
}
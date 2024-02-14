using StringLibrary;

namespace CalculatorMsUnitTests;

[TestClass]
public class AddLogicUnitTest
{
    MathematicalOperation mathematicalOperation = new MathematicalOperation();
  
    [TestMethod]
    public static void AddShouldReturnCorrectSum()
    {
        var firstNumber = 5.0M;
        var secondNumber = 7.0M;
        var result = MathematicalOperation.Add(firstNumber, secondNumber);
       Assert.AreEqual("12.0", result);
    }

    [TestMethod]
    public void WhenBothValuesAreNegativesReturnShouldBeNegative()
    {
        var firstNumber = -9M;
        var secondNumber = -15M;
        var result = MathematicalOperation.Add(firstNumber, secondNumber);
       Assert.AreEqual("-24", result);
    }

    [TestMethod]
    public static void ZeroesShouldReturnedforBelowExpression()
    {
        var firstNumber = -0;
        var secondNumber = -0;
        var result = MathematicalOperation.Add(firstNumber, secondNumber);
       Assert.AreEqual("0", result);
    }

    [TestMethod]
    public static void Add_ShouldHandleNegativeNumbers()
    {
        var firstNumber = -5.00M;
        var secondNumber = 7.00M;
        var result = MathematicalOperation.Add(firstNumber, secondNumber);
       Assert.AreEqual("2", result);
    }

    [TestMethod]
    public void Add_ShouldReturnCorrectAnswerWhenPassedValuesAreDecimals()
    {
        var firstNumber = 5.98M;
        var secondNumber = 7.98M;
        var result = MathematicalOperation.Add(firstNumber, secondNumber);
       Assert.AreEqual("13.96", result);
    }
}
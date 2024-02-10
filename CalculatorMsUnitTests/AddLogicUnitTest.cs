using  CalculatorUnitTestLibrary;
namespace CalculatorMsUnitTests;

[TestClass]
public class AddLogicUnitTest
{
    [TestMethod]
    public void TestMethod1()
    {
        var firstNumber = 5;
        var secondNumber = 7;
        var result = Add(firstNumber, secondNumber);
       Assert.IsTrue(result, $"The result of {result} should have been false for sum of {firstNumber} and {secondNumber}");
    }
}
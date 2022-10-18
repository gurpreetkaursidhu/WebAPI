using CalculatorLogic;
namespace BasicCalculatorTest;


[TestClass]
public class UnitTest1
{
    
    [TestMethod]
    [DataRow(1, 2, 3)]
    [DataRow(1, 1, 2)]
    [DataRow(3, 8, 11)]
    [DataRow(2, 2, 4)]
    [DataRow(3, 3, 6)]
    [DataRow(4, 1, 5)]
    [DataRow(9, 6.7, 15.7)]
    [DataRow(1.2, 1, 2.2)]
    [DataRow(1.2, 1.7, 2.9)]
    [DataRow(5.3, 1, 6.3)]
    public void AdditionTest(double left, double right, double expected)
    {
        var result = CalculatorLogic.CalculatorLogic.Addition(left, right);
        Assert.AreEqual(expected, result);
    }


    [TestMethod]
    [DataRow(2, 1, 1)]
    [DataRow(9, 2, 7)]
    [DataRow(10, 1, 9)]
    [DataRow(2.1, 1, 1.1)]
    [DataRow(9, -8, 17)]
    [DataRow(7.8, 1, 6.8)]
    [DataRow(6, 1, 5)]
    [DataRow(10, 9, 1)]
    [DataRow(4, 1, 3)]
    [DataRow(8, 1, 7)]

    public void SubtractionTest(double left, double right, double expected)
    {
        var result = CalculatorLogic.CalculatorLogic.Substraction(left, right);
        Assert.AreEqual(expected, result);
    }

}

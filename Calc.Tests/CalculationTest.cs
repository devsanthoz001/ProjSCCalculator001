using ProjCalculator;
namespace Calc.Tests;

public class CalculationTest
{
    [Fact]
    public void Add3NosTest1()
    {
        MathManager myobj = new MathManager();
        myobj.Add3Nos();
    }

    [Fact]
    public void Add5NosTest2()
    {
        MathManager myobj = new MathManager();
        myobj.Add5Nos(10);
    }

    [Fact]
    public void Add7NosTest3()
    {
        MathManager myobj = new MathManager();
        int TotalOf7 = myobj.Add7Nos(10,15,25,10);
        System.Console.Write("sumof7NosIs");
        System.Console.WriteLine(TotalOf7);
    }
}
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Library.Tests;

public class OrGateTest
{
    [TestCase(1, 1, 1)]
    [TestCase(0, 1, 1)]
    [TestCase(0, 0, 0)]
    public void OrCalculationTest1(int a, int b, int expectedresult)
    {
        // arrange
        LogicGate or = new OrGate("Or");
        or.AddInput("A", a);
        or.AddInput("B", b);

        // act
        int result = or.Calculate();

        // assert
        Assert.That(result, Is.EqualTo(expectedresult));
    }
}
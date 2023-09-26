using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Library.Tests;

public class AndGateTest
{
    [TestCase(1, 1, 1)]
    [TestCase(1, 0, 0)]
    public void AndCalculationTest1(int a, int b, int expectedresult)
    {
        // arrange
        LogicGate and = new AndGate("AND");
        and.AddInput("A", a);
        and.AddInput("B", b);

        // act
        int result = and.Calculate();

        // assert
        Assert.That(result, Is.EqualTo(expectedresult));
    }
}
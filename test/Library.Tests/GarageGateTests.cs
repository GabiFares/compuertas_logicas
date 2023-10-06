using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Library.Tests;

public class GarageGateTest
{
    [TestCase("1", 0, 0, 0, 0)]
    [TestCase("2", 1, 0, 1, 0)]
    [TestCase("3", 1, 1, 1, 1)]
    [TestCase("4", 0, 0, 1, 1)]
    public void GarageGateTest1(string name, int a, int b, int c, int expectedresult)
    {
        // arrange
        LogicGate garageGate = new GarageGate(name);
        garageGate.AddInput("A", a);
        garageGate.AddInput("B", b);
        garageGate.AddInput("C", c);


        // act
        int result = garageGate.Calculate();

        // assert
        Assert.That(result, Is.EqualTo(expectedresult));
    }
}
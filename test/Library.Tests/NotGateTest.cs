using NUnit.Framework;

namespace Library.Tests;

public class NotGateTest
{
    [TestCase(1, 0)]
    [TestCase(0, 1)]
    [TestCase(5, -1)]
    public void NotCalculationTest1(int a, int expectedresult)
    {
        // arrange
        NotGate not = new NotGate("Not");
        not.AddInput("a", a);

        // act
        int result = not.Value;

        // assert
        Assert.That(result, Is.EqualTo(expectedresult));
    }
}

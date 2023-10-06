using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

namespace Library;

public class GarageGate : LogicGate
{
    public GarageGate(string name) : base(name) { }
    public override void AddInput(string name, int input)
    {
        InputDictionary[name] = input;
    }
    public override int Calculate()
    {
        int a = InputDictionary.Values.ElementAtOrDefault(0);
        int b = InputDictionary.Values.ElementAtOrDefault(1);
        int c = InputDictionary.Values.ElementAtOrDefault(2);

        int and1 = CalculateAndGate("AND1", a, b);
        int not1 = CalculateNotGate("NOT1", a);
        int not2 = CalculateNotGate("NOT2", b);
        int and2 = CalculateAndGate("AND2", not1, not2);
        int or1 = CalculateOrGate("OR1", and1, and2);
        int and3 = CalculateAndGate("AND3", or1, c);
        return and3;
    }

    private int CalculateAndGate(string name, int a, int b)
    {
        LogicGate andGate = new AndGate(name);
        andGate.AddInput("A", a);
        andGate.AddInput("B", b);
        andGate.Value = andGate.Calculate();
        return andGate.Value;
    }

    private int CalculateNotGate(string name, int a)
    {
        LogicGate notGate = new NotGate(name);
        notGate.AddInput("A", a);
        notGate.Calculate();
        return notGate.Value;
    }

    private int CalculateOrGate(string name, int a, int b)
    {
        LogicGate orGate = new OrGate(name);
        orGate.AddInput("A", a);
        orGate.AddInput("B", b);
        orGate.Value = orGate.Calculate();
        return orGate.Value;
    }
}

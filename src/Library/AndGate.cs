namespace Library;

public class AndGate : LogicGate
{
    public AndGate(string name) : base(name) { }

    public override void AddInput(string name, int input)
    {
        InputDictionary[name] = input;
    }
    public override int Calculate()
    {
        Value = 1;
        foreach (int constat in InputDictionary.Values)
        {
            Value = Value * constat;
        }
        return Value;
    }
}

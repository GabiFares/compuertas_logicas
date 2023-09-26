namespace Library;

public class AndGate : LogicGate
{
    public AndGate(string name) : base(name) { }

    public override int Calculate()
    {
        int result = 1;
        foreach (int constat in InputDictionary.Values)
        {
            result = result * constat;
        }
        return result;
    }
}

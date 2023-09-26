namespace Library;

public class OrGate : LogicGate
{
    public OrGate(string name) : base(name) { }
    public override int Calculate()
    {
        int result = 0;
        foreach (int constat in InputDictionary.Values)
        {
            result += constat;
        }
        return result > 0 ? 1 : 0;
    }
}

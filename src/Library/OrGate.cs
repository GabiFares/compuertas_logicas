namespace Library;

public class OrGate : LogicGate
{
    public OrGate(string name) : base(name) { }
    public override void AddInput(string name, int input)
    {
        InputDictionary[name] = input;
    }
    public override int Calculate()
    {
        Value = 0;
        foreach (int constat in InputDictionary.Values)
        {
            Value += constat;
        }
        Value = Value > 0 ? 1 : 0; // Operación ternaria que evalua el resultado y dependiendo de lo que sea devolverá 1 o 0. 
        return Value;
    }
}

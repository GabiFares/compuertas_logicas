using System;

namespace Library;

public abstract class LogicGate
{
    public string Name { get; set; }
    public int Value { get; set; }
    public Dictionary<string, int> InputDictionary = new Dictionary<string, int>();

    public LogicGate(string name)
    {
        this.Name = name;
    }

    public abstract void AddInput(string name, int value);
    public abstract int Calculate();

}

namespace Library;

public class NotGate : LogicGate
{
    public int Input { get; set; }

    public NotGate(string name) : base(name) { }

    public override void AddInput(string name, int input)
    {
        InputDictionary[name] = input;
        Input = input;
        Value = Calculate();
    }

    public override int Calculate()
    {
        if (Input != 0 && Input != 1)
        {
            return -1; // Si no es válido en numero, devuelve el error expresado en el número -1
        }
        return (Input == 1) ? 0 : 1;
    }
}

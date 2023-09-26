namespace Library;

public class NotGate
{
    public string Name { get; set; }
    public int Value { get; set; }

    public NotGate(string name, int value)
    {
        this.Name = name;
        this.Value = Calculate(value);
    }

    private int Calculate(int number)
    {
        if (number != 0 && number != 1)
        {
            return -1; // Si no es válido en numero, devulve el error expresado en el número -1
        }
        return (number == 1) ? 0 : 1;
    }
}

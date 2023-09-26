using System;

namespace Library;

public abstract class LogicGate
{
    public string Name { get; set; }
    public Dictionary<string, int> InputDictionary = new Dictionary<string, int>();


    public LogicGate(string name)
    {
        this.Name = name;
    }

    public void AddInput(string name, int value)
    {
        InputDictionary[name] = value; // Si la entrada ya existe, el valor se debería cambiar por el nuevo valor, y sino se debería crear. En todos los casos, esta línea
                                       // de código se escribe. El único caso en el que no haría nada, sería en el que la entrada existiera y el valor fuera el mismo, pero
                                       // de todas maneras, si se escribe esta linea en ese caso, la entrada seguirá teniendo el mismo valor. Por lo que se ahorra el hacer 
                                       // más lineas de código y procesamiento al hacerlo de esta manera. 
    }

    public abstract int Calculate();

}

namespace DefaultNamespace;
public class Nodo
{
    public int Dato { get; set; }
    public Nodo Siguiente { get; set; }

    public Nodo(int dato)
    {
        this.Dato = dato;
        this.Siguiente = null;
    }
}


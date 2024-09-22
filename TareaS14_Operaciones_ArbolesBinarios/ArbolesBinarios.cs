public class ArbolesBinarios
{
    private Nodo Raiz;

    public ArbolesBinarios()
    {
        Raiz = null;
    }

    // Método para mostrar el árbol en orden
    public void MostrarEnOrden()
    {
        MostrarEnOrdenRecursivo(Raiz);
        Console.WriteLine();
    }

    private void MostrarEnOrdenRecursivo(Nodo nodo)
    {
        if (nodo != null)
        {
            MostrarEnOrdenRecursivo(nodo.Izquierda);
            Console.Write(nodo.Valor + " ");
            MostrarEnOrdenRecursivo(nodo.Derecha);
        }
    }

    public Nodo GetRaiz()
    {
        return Raiz;
    }

    public void SetRaiz(Nodo raiz)
    {
        Raiz = raiz;
    }
}
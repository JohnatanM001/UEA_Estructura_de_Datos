namespace DefaultNamespace;
public class Programa
{
    public static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);

        int numeroElementos = lista.ContarElementos();
        Console.WriteLine("Número de elementos en la lista: " + numeroElementos);
    }
}
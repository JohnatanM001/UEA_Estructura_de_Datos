namespace DefaultNamespace;

public class Clase_Torres
{
    private static Stack<int> torre1 = new Stack<int>();
    private static Stack<int> torre2 = new Stack<int>();
    private static Stack<int> torre3 = new Stack<int>();

    public static void Ejecutar()
    {
        InicializarTorres();
        Console.Write("Ingrese el número de discos: ");
        int numDiscos = int.Parse(Console.ReadLine());

        for (int i = numDiscos; i >= 1; i--)
        {
            torre1.Push(i);
        }
        MostrarTorres();

        MoverDiscos(numDiscos, torre1, torre3, torre2);
    }

    private static void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar)
    {
        if (n == 1)
        {
            TransferirDisco(origen, destino);
            MostrarTorres();
        }
        else
        {
            MoverDiscos(n - 1, origen, auxiliar, destino);
            TransferirDisco(origen, destino);
            MostrarTorres();
            MoverDiscos(n - 1, auxiliar, destino, origen);
        }
    }

    private static void TransferirDisco(Stack<int> origen, Stack<int> destino)
    {
        destino.Push(origen.Pop());
    }

    private static void MostrarTorres()
    {
        Console.WriteLine("Estado actual de las Torres:");
        Console.WriteLine("Torre 1: {0}", string.Join(", ", torre1.Reverse()));
        Console.WriteLine("Torre 2: {0}", string.Join(", ", torre2.Reverse()));
        Console.WriteLine("Torre 3: {0}", string.Join(", ", torre3.Reverse()));
        Console.WriteLine(new string('-', 30));
    }

    private static void InicializarTorres()
    {
        torre1.Clear();
        torre2.Clear();
        torre3.Clear();
    }
}
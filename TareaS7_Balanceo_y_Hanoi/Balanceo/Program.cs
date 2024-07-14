namespace DefaultNamespace;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una ecuación:");
        string ecuacion = Console.ReadLine();

        // Utilizamos el método de Clase_Formula para verificar si la ecuación está balanceada
        string resultado = Clase_Formula.VerificarBalanceo(ecuacion);

        // Mostramos el resultado al usuario
        Console.WriteLine("La ecuación es " + resultado);
    }
}
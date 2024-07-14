namespace DefaultNamespace;
using System.Collections.Generic;
public class Clase_Formula
{
    // Método para verificar si la fórmula tiene paréntesis balanceados
    public static string VerificarBalanceo(string formula)
    {
        Stack<char> pilaParentesis = new Stack<char>();
        int contadorAbiertos = 0;
        int contadorCerrados = 0;

        foreach (char simbolo in formula)
        {
            pilaParentesis.Push(simbolo); // Insertamos cada símbolo en la pila
        }

        // Imprimimos los elementos de la pila (opcional)
        ImprimirPila(pilaParentesis);

        while (pilaParentesis.Count > 0)
        {
            char simbolo = pilaParentesis.Pop();
            if (simbolo == '(')
            {
                contadorAbiertos++;
            }
            else if (simbolo == ')')
            {
                contadorCerrados++;
            }
        }

        // Evaluamos si los paréntesis están balanceados
        return contadorAbiertos == contadorCerrados ? "Balanceada" : "NO balanceada";
    }

    // Método para imprimir los elementos de la pila
    private static void ImprimirPila(Stack<char> pila)
    {
        Console.WriteLine("Elementos de la pila:");
        foreach (var item in pila)
        {
            Console.WriteLine(item);
        }
    }
}
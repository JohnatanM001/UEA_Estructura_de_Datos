using System;

class Programa
{
    static void Main()
    {
        Diccionario diccionario = new Diccionario();

        while (true)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("=======================================================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            if (opcion == "0")
            {
                break;
            }
            else if (opcion == "1")
            {
                Console.Write("Ingrese la frase: ");
                string frase = Console.ReadLine();
                string fraseTraducida = diccionario.Traducir(frase);
                Console.WriteLine("Su frase traducida es: " + fraseTraducida);
            }
            else if (opcion == "2")
            {
                diccionario.AgregarPalabras();
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
            }
        }
    }
}
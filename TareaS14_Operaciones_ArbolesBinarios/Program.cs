using System;

class Program
{
    static void Main(string[] args)
    {
        ArbolesBinarios arbol = new ArbolesBinarios();
        Operaciones operaciones = new Operaciones(arbol);
        int opcion, valor;

        do
        {
            Console.WriteLine("*********Menu*********");
            Console.WriteLine("1. Insertar un valor");
            Console.WriteLine("2. Eliminar un valor");
            Console.WriteLine("3. Mostrar en orden");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el valor a insertar: ");
                    valor = Convert.ToInt32(Console.ReadLine());
                    operaciones.Insertar(valor);
                    break;
                case 2:
                    Console.Write("Ingrese el valor a eliminar: ");
                    valor = Convert.ToInt32(Console.ReadLine());
                    operaciones.Eliminar(valor);
                    break;
                case 3:
                    Console.WriteLine("Árbol en orden:");
                    arbol.MostrarEnOrden();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 0);
    }
}
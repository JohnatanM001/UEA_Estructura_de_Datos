using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> catalogo = new List<string>();
        Busqueda busqueda = new Busqueda();
        
        // Ingresar 10 títulos al catálogo
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Ingrese el título de la revista {i}: ");
            catalogo.Add(Console.ReadLine());
        }

        bool salir = false;
        
        while (!salir)
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Buscar título con búsqueda iterativa");
            Console.WriteLine("2. Buscar título con búsqueda recursiva");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            
            int opcion = int.Parse(Console.ReadLine());
            
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el título a buscar: ");
                    string tituloIterativo = Console.ReadLine();
                    bool encontradoIterativa = busqueda.BuscarIterativa(catalogo, tituloIterativo);
                    Console.WriteLine(encontradoIterativa ? "Título encontrado" : "Título no encontrado");
                    break;
                    
                case 2:
                    Console.Write("Ingrese el título a buscar: ");
                    string tituloRecursivo = Console.ReadLine();
                    bool encontradoRecursiva = busqueda.BuscarRecursiva(catalogo, tituloRecursivo);
                    Console.WriteLine(encontradoRecursiva ? "Título encontrado" : "Título no encontrado");
                    break;
                    
                case 3:
                    salir = true;
                    break;
                    
                default:
                    Console.WriteLine("Opción no válida, intente nuevamente.");
                    break;
            }
        }
    }
}

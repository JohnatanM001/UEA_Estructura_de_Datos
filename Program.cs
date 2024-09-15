using System;

public class Program
{
    public static void Main(string[] args)
    {
        Registro registro = new Registro();
        string opcion;

        do
        {
            Console.WriteLine("\n--- Menú Biblioteca ---");
            Console.WriteLine("1. Agregar un libro");
            Console.WriteLine("2. Mostrar todos los libros");
            Console.WriteLine("3. Eliminar un libro por ISBN");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    // Solicitar datos del libro al usuario
                    Console.Write("Ingrese el título del libro: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Ingrese el autor del libro: ");
                    string autor = Console.ReadLine();
                    Console.Write("Ingrese el ISBN del libro: ");
                    string isbn = Console.ReadLine();

                    // Crear un objeto Libro y agregarlo al registro
                    Libro nuevoLibro = new Libro(titulo, autor, isbn);
                    registro.AgregarLibro(nuevoLibro);
                    break;

                case "2":
                    // Mostrar todos los libros registrados
                    registro.MostrarLibros();
                    break;

                case "3":
                    // Solicitar el ISBN del libro a eliminar
                    Console.Write("Ingrese el ISBN del libro que desea eliminar: ");
                    string isbnEliminar = Console.ReadLine();
                    registro.EliminarLibro(isbnEliminar);
                    break;

                case "4":
                    // Salir del programa
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

        } while (opcion != "4");
    }
}
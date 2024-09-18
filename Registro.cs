using System;
using System.Collections.Generic;

public class Registro
{
    // Atributos
    private List<Libro> libros;

    // Constructor
    public Registro()
    {
        libros = new List<Libro>();
    }

    // Método para agregar un libro al registro
    public void AgregarLibro(Libro libro)
    {
        libros.Add(libro);
        Console.WriteLine("Libro agregado correctamente.");
    }

    // Método para eliminar un libro por ISBN
    public void EliminarLibro(string isbn)
    {
        Libro libroAEliminar = libros.Find(libro => libro.ISBN == isbn);
        if (libroAEliminar != null)
        {
            libros.Remove(libroAEliminar);
            Console.WriteLine("Libro eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("No se encontró un libro con ese ISBN.");
        }
    }

    // Método para mostrar los libros registrados
    public void MostrarLibros()
    {
        if (libros.Count == 0)
        {
            Console.WriteLine("No hay libros registrados.");
            return;
        }

        Console.WriteLine("Libros en la biblioteca:");
        foreach (var libro in libros)
        {
            Console.WriteLine(libro.ToString());
        }
    }
}

public class Libro
{
    // Atributos
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }

    // Constructor
    public Libro(string titulo, string autor, string isbn)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
    }

    // Método ToString para mostrar la información del libro
    public override string ToString()
    {
        return $"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}";
    }
}
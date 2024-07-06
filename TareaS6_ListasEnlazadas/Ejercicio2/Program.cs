nusing System;
namespace ListaEnlazadaInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Agregar elementos a la lista
            lista.Agregar(1);
            lista.Agregar(2);
            lista.Agregar(3);
            lista.Agregar(4);
            lista.Agregar(5);

            // Imprimir lista original
            Console.WriteLine("Lista original:");
            lista.Imprimir();

            // Invertir la lista
            lista.Invertir();

            // Imprimir lista invertida
            Console.WriteLine("Lista invertida:");
            lista.Imprimir();
        }
    }
}
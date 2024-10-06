using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Crear el grafo de vuelos
        GrafoDeVuelos grafoDeVuelos = new GrafoDeVuelos();

        // Agregando aeropuertos y vuelos
        grafoDeVuelos.AgregarVuelo("Quito", "Guayaquil", 100.0, new TimeSpan(1, 0, 0));
        grafoDeVuelos.AgregarVuelo("Quito", "Cuenca", 80.0, new TimeSpan(0, 50, 0));
        grafoDeVuelos.AgregarVuelo("Cuenca", "Guayaquil", 70.0, new TimeSpan(0, 45, 0));
        grafoDeVuelos.AgregarVuelo("Guayaquil", "Lima", 150.0, new TimeSpan(2, 0, 0));
        grafoDeVuelos.AgregarVuelo("Quito", "Lima", 200.0, new TimeSpan(2, 30, 0));

        // Crear el buscador de vuelos
        BuscadorDeVuelos buscador = new BuscadorDeVuelos(grafoDeVuelos);

        // Pedir origen y destino al usuario
        Console.WriteLine("Ingrese el aeropuerto de origen:");
        string origen = Console.ReadLine();
        Console.WriteLine("Ingrese el aeropuerto de destino:");
        string destino = Console.ReadLine();

        // Buscar vuelos baratos
        List<Vuelo> vuelosBaratos = buscador.EncontrarVuelosBaratos(origen, destino);

        // Mostrar resultados
        if (vuelosBaratos.Count > 0)
        {
            Console.WriteLine("Vuelos encontrados:");
            foreach (Vuelo vuelo in vuelosBaratos)
            {
                Console.WriteLine($"{vuelo.Origen} -> {vuelo.Destino}: ${vuelo.Costo}, Duración: {vuelo.Duracion}");
            }
        }
        else
        {
            Console.WriteLine("No se encontraron vuelos entre los aeropuertos especificados.");
        }
    }
}
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Crear el grafo
        Grafo grafo = new Grafo();

        // Leer los vuelos del archivo txt
        string[] lineas = File.ReadAllLines("vuelos.txt");
        foreach (var linea in lineas)
        {
            var datos = linea.Split(',');
            string origen = datos[0];
            string destino = datos[1];
            decimal precio = decimal.Parse(datos[2]);
            grafo.AgregarVuelo(new Vuelo(origen, destino, precio));
        }

        // Buscar vuelos baratos
        BuscadorVuelos buscador = new BuscadorVuelos(grafo);
        buscador.BuscarVuelosBaratos("A", "C");
        buscador.BuscarVuelosBaratos("A", "D");
    }
}
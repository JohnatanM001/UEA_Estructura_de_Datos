using System;
using System.Collections.Generic;

public class BuscadorVuelos
{
    private Grafo _grafo;

    public BuscadorVuelos(Grafo grafo)
    {
        _grafo = grafo;
    }

    public void BuscarVuelosBaratos(string origen, string destino)
    {
        var vuelosPosibles = _grafo.ObtenerVuelosDesde(origen);
        Vuelo vueloBarato = null;

        foreach (var vuelo in vuelosPosibles)
        {
            if (vuelo.Destino == destino)
            {
                if (vueloBarato == null || vuelo.Precio < vueloBarato.Precio)
                {
                    vueloBarato = vuelo;
                }
            }
        }

        if (vueloBarato != null)
        {
            Console.WriteLine($"Vuelo barato encontrado de {origen} a {destino}: {vueloBarato.Precio:C}");
        }
        else
        {
            Console.WriteLine($"No se encontraron vuelos de {origen} a {destino}.");
        }
    }
}
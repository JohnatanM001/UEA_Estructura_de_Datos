using System.Collections.Generic;

public class Grafo
{
    private Dictionary<string, List<Vuelo>> _adjacencyList;

    public Grafo()
    {
        _adjacencyList = new Dictionary<string, List<Vuelo>>();
    }

    public void AgregarVuelo(Vuelo vuelo)
    {
        if (!_adjacencyList.ContainsKey(vuelo.Origen))
        {
            _adjacencyList[vuelo.Origen] = new List<Vuelo>();
        }
        _adjacencyList[vuelo.Origen].Add(vuelo);
    }

    public List<Vuelo> ObtenerVuelosDesde(string origen)
    {
        return _adjacencyList.ContainsKey(origen) ? _adjacencyList[origen] : new List<Vuelo>();
    }
}
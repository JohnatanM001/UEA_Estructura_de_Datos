public class BuscadorDeVuelos
{
    private GrafoDeVuelos grafo;

    public BuscadorDeVuelos(GrafoDeVuelos grafoDeVuelos)
    {
        grafo = grafoDeVuelos;
    }

    public List<Vuelo> EncontrarVuelosBaratos(string origen, string destino)
    {
        // Implementamos un DFS o BFS para encontrar la ruta más barata
        Stack<string> pila = new Stack<string>();
        List<Vuelo> rutaOptima = new List<Vuelo>();
        Dictionary<string, bool> visitado = new Dictionary<string, bool>();

        pila.Push(origen);
        while (pila.Count > 0)
        {
            string aeropuertoActual = pila.Pop();
            if (aeropuertoActual == destino)
            {
                break;
            }

            if (!visitado.ContainsKey(aeropuertoActual))
            {
                visitado[aeropuertoActual] = true;

                foreach (var vuelo in grafo.Aeropuertos[aeropuertoActual].VuelosDisponibles)
                {
                    pila.Push(vuelo.Destino);
                    rutaOptima.Add(vuelo);
                }
            }
        }
        return rutaOptima;
    }
}
public class GrafoDeVuelos
{
    public Dictionary<string, Aeropuerto> Aeropuertos { get; set; }

    public GrafoDeVuelos()
    {
        Aeropuertos = new Dictionary<string, Aeropuerto>();
    }

    public void AgregarAeropuerto(string nombre)
    {
        if (!Aeropuertos.ContainsKey(nombre))
        {
            Aeropuertos[nombre] = new Aeropuerto(nombre);
        }
    }

    public void AgregarVuelo(string origen, string destino, double costo, TimeSpan duracion)
    {
        AgregarAeropuerto(origen);
        AgregarAeropuerto(destino);
        Vuelo vuelo = new Vuelo(origen, destino, costo, duracion);
        Aeropuertos[origen].AgregarVuelo(vuelo);
    }
}
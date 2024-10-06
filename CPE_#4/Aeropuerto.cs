public class Aeropuerto
{
    public string Nombre { get; set; }
    public List<Vuelo> VuelosDisponibles { get; set; }

    public Aeropuerto(string nombre)
    {
        Nombre = nombre;
        VuelosDisponibles = new List<Vuelo>();
    }

    public void AgregarVuelo(Vuelo vuelo)
    {
        VuelosDisponibles.Add(vuelo);
    }
}
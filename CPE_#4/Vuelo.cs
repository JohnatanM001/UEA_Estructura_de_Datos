public class Vuelo
{
    public string Origen { get; set; }
    public string Destino { get; set; }
    public double Costo { get; set; }
    public TimeSpan Duracion { get; set; }

    public Vuelo(string origen, string destino, double costo, TimeSpan duracion)
    {
        Origen = origen;
        Destino = destino;
        Costo = costo;
        Duracion = duracion;
    }
}
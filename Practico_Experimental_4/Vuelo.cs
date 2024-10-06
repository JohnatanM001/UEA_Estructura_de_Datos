public class Vuelo
{
    public string Origen { get; set; }
    public string Destino { get; set; }
    public decimal Precio { get; set; }

    public Vuelo(string origen, string destino, decimal precio)
    {
        Origen = origen;
        Destino = destino;
        Precio = precio;
    }
}
namespace ListaEnlazadaInversa
{
    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo? Siguiente { get; set; } // Permite valores nulos

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }
}
namespace ListaEnlazadaInversa
{
    public class ListaEnlazada
    {
        private Nodo? cabeza;

        public ListaEnlazada()
        {
            cabeza = null;
        }

        // Método para agregar un nuevo nodo al final de la lista
        public void Agregar(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        // Método para invertir la lista enlazada
        public void Invertir()
        {
            Nodo? previo = null;
            Nodo? actual = cabeza;
            Nodo? siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Siguiente;
                actual.Siguiente = previo;
                previo = actual;
                actual = siguiente;
            }
            cabeza = previo;
        }

        // Método para imprimir los elementos de la lista
        public void Imprimir()
        {
            Nodo? actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }
    }
}
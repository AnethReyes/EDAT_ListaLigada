using ListaLigada.Logica;

namespace ListaLigada.UI.Consola
{
        public class SingleList<T>
    {
        private SingleNode<T> _first;

        //Puntero del primer nodo
        public SingleList()
        {
            _first = null;
        }

        //Para saber si esta vacia
        public bool isEmpty => _first == null;

        //Metodo para agregar nodo
        public void Add(T item)
        {

            //Crear objeto nodo e invocar a SingleNode

            var node = new SingleNode<T>(item);

            if (isEmpty)
            {
                _first = node;
            }
            else
            {
                var pointer = _first;

                while (pointer!.Next != null)
                {
                    pointer = pointer.Next;
                }

                pointer!.Next = node;
            }


        }

        public override string ToString()
        {
            var cadenaLista = string.Empty;
            var pointer = _first;

            while (pointer != null)
            {
                cadenaLista += $"{pointer.Data}\n";
                pointer = pointer.Next;
            }
            return cadenaLista;
        }
    }
}

using ListaLigada.UI.Consola;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! Lista ligada Simple");

        Console.WriteLine("");
        var singleList = new SingleList<string>();

        int opcion = 0;

        do
        {

            opcion = Menu();
            switch (opcion)
            {
                case 1: AgregarElemento(); break;
                case 2: MostrarLista(); break;
                case 3: break;
                case 0: break;

                default: Console.WriteLine("Esta opcion no existe"); break;
            }

        }

        while (opcion != 0);

        void AgregarElemento()
        {
            Console.WriteLine("Escribe el nombre del nodo");
            var data = Console.ReadLine();
            singleList.Add(data);
        }
         void MostrarLista()
         {
            Console.WriteLine("La lista es\n");
            Console.WriteLine(singleList);
        }
        
        Console.ReadKey();
    }



    private static int Menu()
    {

        Console.WriteLine("Menu\n");
        Console.WriteLine("1. Agregar elemento\n");
        Console.WriteLine("2. Mostrar lista\n");
        Console.WriteLine("0. Salir\n");
    
        bool esValido = false;

        int opcion =  0;

        do
        {

            Console.WriteLine("Elige una opcion del menu");
            var opcionCapturada = Console.ReadLine();

            if (!int.TryParse(opcionCapturada,out opcion)|| opcion < 0 || opcion > 2)
            {
                Console.WriteLine("Digite una opcion valida");
                esValido = false;
            }
            else
            {
                esValido = true;
            }

        }
        while (esValido==false);
        
        return opcion;
    }
}
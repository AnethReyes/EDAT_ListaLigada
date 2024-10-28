using ListaLigada.UI.Consola;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! Lista ligada Simple");

        Console.WriteLine("");
        var singleList = new SingleList<string>();

        singleList.Add("Carlos");
        singleList.Add("Ingrid");
        singleList.Add("Cesar");
        singleList.Add("Pris");
        singleList.Add("Uriel");

        Console.WriteLine(singleList);


        Console.ReadKey();
    }
}
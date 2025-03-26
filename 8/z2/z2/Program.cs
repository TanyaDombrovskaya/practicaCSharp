using BagNamespace;

class Program
{
    static void Main()
    {
        BagManager<string> bagManager = new BagManager<string>();

        bagManager.AddItem("Меч");
        bagManager.AddItem("Щит");
        bagManager.AddItem("Зелье здоровья");

        Console.WriteLine();
        bagManager.PrintAllItems();

        Console.WriteLine();
        bagManager.CheckItem("Щит");
        bagManager.CheckItem("Доспех");

        Console.WriteLine();
        bagManager.RemoveItem("Меч");
        bagManager.PrintAllItems();

        Console.WriteLine();
        bagManager.ClearBag();
        bagManager.PrintAllItems();
    }
}

using InventoryNamespace;

class Task2
{
    static void Main()
    {
        string[] inventories = {"кружка", "стол", "ложка"};

        Inventory inventory = new(inventories);

        Console.Write("Введите товар для поиска: ");
        string item = Console.ReadLine();

        try
        {
            inventory.CheckStrong(item);
        }
        catch (OutOfStockExeption ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
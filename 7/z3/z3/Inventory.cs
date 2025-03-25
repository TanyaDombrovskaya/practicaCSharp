namespace InventoryNamespace
{
    public class OutOfStockExeption : Exception {
        public OutOfStockExeption(string message)
            : base(message)
        {
        }
    }

    public class Inventory
    {
        private string[] _inventory;

        public Inventory(string[] inventory)
        { 
            _inventory = inventory;
        }

        public void CheckStrong(string item)
        {
            if (!_inventory.Contains(item))
            {
                throw new OutOfStockExeption($"Товар {item} не обнаружен.");
            }
            else
            {
                Console.WriteLine($"Товар {item} обнаружен.");
            }
        }
    }
}

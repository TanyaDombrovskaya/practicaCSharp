using OrderNamespace;

class Task3
{
    static void Main()
    {
        Order[] orders = new Order[]
            {
                new OnlineOrder(1, "Иван", 2500, "ул. Ленина, 1"),
                new InStoreOrder(2, "Мария", 1500, "Online-Store"),
                new OnlineOrder(3, "Иван", 3000, "ул. Советская, 10")
            };

        Store store = new Store(orders);

        store.Show();

        var largestOrder = store.GetLargestOrder();
        Console.WriteLine($"\nСамый большой заказ: {largestOrder.CustomerName}, сумма: {largestOrder.TotalAmount}");

        Console.Write("Введите имя: ");
        string name = Console.ReadLine();

        var customerOrders = store.GetOrdersByCustomer(name);
        Console.WriteLine($"\nЗаказы клиента {name}:");
        foreach (var order in customerOrders)
        {
            Console.WriteLine($"Заказ {order.OrderId}, сумма: {order.TotalAmount}");
        }
    }
}
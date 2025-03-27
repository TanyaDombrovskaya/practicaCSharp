using CustomerNamespace;

class Task2
{
    static void Main()
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer(1, "John Doe"),
            new Customer(2, "Jane Smith"),
            new Customer(3, "Alice Johnson"),
            new Customer(1, "John Doe"),
            new Customer(2, "Jane Smith"),
            new Customer(4, "Bob Brown")
        };

        string filePath = "file.data";

        CustomerFileWriter writer = new CustomerFileWriter(filePath);
        writer.WriteUniqueCustomers(customers);

        Console.WriteLine("Готово.");
    }
}

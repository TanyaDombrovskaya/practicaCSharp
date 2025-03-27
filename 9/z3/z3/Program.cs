using CustomerNS;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string filePath = "file.data";

        CustomerFileReader reader = new CustomerFileReader(filePath);
        List<Customer> customers = reader.ReadCustomers();

        Console.WriteLine("Список всех клиентов:");
        foreach (var customer in customers)
        {
            Console.WriteLine(customer);
        }

        CustomerProcessor processor = new CustomerProcessor();
        List<Customer> duplicates = processor.FindDuplicates(customers);

        Console.WriteLine("\nДубликаты по Id:");
        if (duplicates.Count > 0)
        {
            foreach (var duplicate in duplicates)
            {
                Console.WriteLine(duplicate);
            }
        }
        else
        {
            Console.WriteLine("Дубликатов не найдено.");
        }
    }
}

namespace CustomerNS
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }

    public class CustomerFileReader
    {
        private string _filePath;

        public CustomerFileReader(string filePath)
        {
            _filePath = filePath;
        }

        public List<Customer> ReadCustomers()
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                if (!File.Exists(_filePath))
                {
                    throw new FileNotFoundException("Файл не найден.");
                }

                foreach (var line in File.ReadLines(_filePath))
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[0], out int id))
                    {
                        customers.Add(new Customer(id, parts[1]));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }

            return customers;
        }
    }

    public class CustomerProcessor
    {
        public List<Customer> FindDuplicates(List<Customer> customers)
        {
            return customers
                .GroupBy(c => c.Id)
                .Where(group => group.Count() > 1)
                .SelectMany(group => group)
                .ToList();
        }
    }
}

namespace CustomerNamespace
{
    public class CustomerFileWriter
    {
        private string _filePath;

        public CustomerFileWriter(string filePath)
        {
            _filePath = filePath;
        }

        public void WriteUniqueCustomers(List<Customer> customers)
        {
            HashSet<Customer> uniqueCustomers = new HashSet<Customer>(customers);

            try
            {
                using (StreamWriter writer = new StreamWriter(_filePath, false))
                {
                    foreach (var customer in uniqueCustomers)
                    {
                        writer.WriteLine($"{customer.Id},{customer.Name}");
                    }
                }

                Console.WriteLine($"Уникальные клиенты успешно записаны в файл: {_filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при записи в файл: {ex.Message}");
            }
        }
    }
}

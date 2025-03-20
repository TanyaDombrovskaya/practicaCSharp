namespace OrderNamespace
{
    public class Store
    {
        private Order[] _orders { get; set; }

        public Store(Order[] orders)
        {
            _orders = orders;
        }

        public void Show()
        {
            foreach (var order in _orders) { 
                Console.WriteLine($"{order.OrderId} - {order.CustomerName} - {order.TotalAmount}");
            }
        }

        public Order GetLargestOrder()
        {
            return _orders.OrderByDescending(o => o.TotalAmount).FirstOrDefault();
        }

        public Order[] GetOrdersByCustomer(string name)
        {
            return _orders.Where(o => o.CustomerName.Equals(name, StringComparison.OrdinalIgnoreCase)).ToArray();
        }
    }
}

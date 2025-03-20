namespace OrderNamespace
{
    public abstract class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }

        public Order(int orderId, string customerName, decimal totalAmount)
        {
            OrderId = orderId;
            CustomerName = customerName;
            TotalAmount = totalAmount;
        }
    }
}

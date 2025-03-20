namespace OrderNamespace
{
    sealed class OnlineOrder : Order
    {
        public string Address { get; set; }

        public OnlineOrder(int orderId, string customerName, decimal totalAmount, string address)
            : base(orderId, customerName, totalAmount)
        {
            Address = address;
        }
    }
}


namespace OrderNamespace
{
    sealed class InStoreOrder : Order
    {
        public string Location { get; set; }

        public InStoreOrder(int orderId, string customerName, decimal totalAmount, string location)
        : base(orderId, customerName, totalAmount)
        {
            Location = location;
        }
    }
}

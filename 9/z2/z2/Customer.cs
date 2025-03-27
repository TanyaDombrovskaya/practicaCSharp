namespace CustomerNamespace
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

        public override bool Equals(object obj)
        {
            if (obj is Customer customer)
            {
                return Id == customer.Id && Name == customer.Name;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }

}

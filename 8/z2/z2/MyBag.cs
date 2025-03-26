namespace BagNamespace
{
    public class MyBag<T>
    {
        private List<T> _items; // Список для хранения элементов

        public MyBag()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public bool Remove(T item)
        {
            return _items.Remove(item);
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public int Count()
        {
            return _items.Count;
        }

        public List<T> GetAllItems()
        {
            return new List<T>(_items);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public void Print()
        {
            Console.WriteLine("Содержимое MyBag:");
            foreach (var item in _items)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}

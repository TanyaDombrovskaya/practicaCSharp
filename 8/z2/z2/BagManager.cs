namespace BagNamespace
{
    public class BagManager<T>
    {
        private MyBag<T> _bag;

        public BagManager()
        {
            _bag = new MyBag<T>();
        }

        public void AddItem(T item)
        {
            _bag.Add(item);
            Console.WriteLine($"Добавлено: {item}");
        }

        public void RemoveItem(T item)
        {
            if (_bag.Remove(item))
            {
                Console.WriteLine($"Удалено: {item}");
            }
            else
            {
                Console.WriteLine($"Элемент {item} не найден в сумке.");
            }
        }

        public void CheckItem(T item)
        {
            if (_bag.Contains(item))
            {
                Console.WriteLine($"Элемент {item} присутствует в сумке.");
            }
            else
            {
                Console.WriteLine($"Элемента {item} нет в сумке.");
            }
        }

        public void PrintAllItems()
        {
            _bag.Print();
        }

        public void ClearBag()
        {
            _bag.Clear();
            Console.WriteLine("Сумка очищена.");
        }
    }
}

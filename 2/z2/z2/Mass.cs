namespace MassNamespace
{
    class Mass
    {
        private int[] _array;

        public Mass(int[] array)
        { 
            _array = array;
        }

        public void Create()
        {
            Random random = new();

            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = random.Next(-50, 50);
            }
        }

        public void Show()
        {
            for (int i = 0; i < _array.Length; i++)
            { 
                Console.Write($"{_array[i]} " );
            }
        }

        public void Sort()
        {
            int count = _array.Length;

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (_array[j] > _array[j + 1])
                    {
                        int temp = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = temp;
                    }
                }
            }
        }

        public int BinarySearch(int number)
        {
            int left = 0; 
            int right = _array.Length - 1; 

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (_array[mid] == number)
                    return mid;

                else if (_array[mid] < number)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }

        public void RemoveMax()
        {
            var list = _array.ToList();

            int max = list.Max();

            list.RemoveAll(x => x == max);

            _array = list.ToArray();
        }

        public void RemoveMin()
        {
            var list = _array.ToList();

            int min = list.Min();

            list.RemoveAll(x => x == min);

            _array = list.ToArray();
        }
    }
}

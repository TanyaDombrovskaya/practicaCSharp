namespace MassNamespace
{
    class Mass
    {
        private int[] _array;

        public Mass(int[] array)
        {
            _array = array;
        }

        public int CountOfNegativeElements()
        {
            int count = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < 0)
                { 
                    count++;
                }
            }

            return count;
        }
    }
}

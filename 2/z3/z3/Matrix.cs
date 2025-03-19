namespace MatrixNamespace
{
    class Matrix
    {
        private int[,] _matrix;
        private int _N;
        private int _a;
        private int _b;

        public Matrix(int[,] matrix, int N, int a, int b)
        { 
            _matrix = matrix;
            _N = N;
            _a = a;
            _b = b;
        }

        public void Create()
        {
            Random random = new();

            for (int i = 0; i < _N; i++)
            {
                for (int j = 0; j < _N; j++)
                {
                    _matrix[i, j] = random.Next(_a, _b);
                }
            }
        }

        public void Show()
        {
            for (int i = 0; i < _N; i++)
            {
                for (int j = 0; j < _N; j++)
                {
                    Console.Write($"{_matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public double Average(int G)
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < _N; i++)
            {
                for (int j = 0; j < _N; j++)
                {
                    if (_matrix[i, j] > G)
                    { 
                        sum += _matrix[i, j];
                        count++;
                    }
                }
            }

            return (double)sum / count;
        }

        public int HonestCount(int k)
        {
            int count = 0;

            for (int j = 0; j < _N; j++)
            {
                if (_matrix[k, j] % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

    }
}

namespace MatrixNamespace
{
    class Matrix
    {
        private int[,] _matrix;
        private int _rows;        
        private int _cols;

        public Matrix(int[,] matrix, int rows, int cols)
        { 
            _matrix = matrix;
            _rows = rows;
            _cols = cols;
        }

        public void Create()
        {
            Random random = new();

            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    _matrix[i, j] = random.Next(1, 10);
                }
            }
        }

        public void Show()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    Console.Write($"{_matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public int SumOfFirstRow()
        {
            int sum = 0;

            for (int j = 0; j < _cols; j++)
            { 
                sum += _matrix[0, j];
            }

            return sum;
        }

        public int SumOfReLastRow()
        { 
            int sum = 0;

            for (int j = 0; j < _cols; j++)
            {
                sum += _matrix[_rows - 2, j];
            }

            return sum;
        }

        public bool Answer()
        {
            int sum1 = SumOfFirstRow();
            int sum2 = SumOfReLastRow();

            if (sum1 > sum2) return true;
            else return false;
        }
    }
}

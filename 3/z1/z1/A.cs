namespace ANamespace
{
    class A
    {
        private int _a;
        private int _b;

        public A(int a, int b)
        { 
            _a = a;
            _b = b;
        }

        public double Func1()
        {
            return (Math.Sin(_b) + 4) / 2 * _a;
        }

        public double Func2()
        {
            return Math.Pow(_a + _b, 2);
        }

    }
}

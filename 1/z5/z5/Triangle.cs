namespace TriangleNamespace
{
    class Triangle
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        { 
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public bool IsExists()
        {
            if ((_sideA + _sideB) > _sideC && (_sideA + _sideC) > _sideB && (_sideC + _sideB) > _sideA) return true;
            else return false;
        }
    }
}

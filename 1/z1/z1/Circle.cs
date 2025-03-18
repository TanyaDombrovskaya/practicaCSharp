namespace CircleNamespace
{
    class Circle
    {
        private double _radius;

        public Circle(double radius) {
            _radius = radius;
        }

        public double GetLength() {
            return (2 * Math.PI * _radius);
        }

        public double GetSquare() {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}

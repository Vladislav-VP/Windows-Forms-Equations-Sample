using System;

namespace EquationsSample
{
    public class Equation
    {
        private double _minValue;
        private double _maxValue;

        private double _accuracy;

        private double _solution;

        public double CurrentX { get; set; }

        public Equation(double minValue, double maxValue, double accuracy)
        {
            _minValue = minValue;
            _maxValue = maxValue;
            _accuracy = accuracy;
        }

        public double GetSolution()
        {
            Solve();

            return _solution;
        }

        public double GetFunctionValue(double x)
        {
            double y = Math.Pow(x, 3) - Math.Pow(x, 2) + 3;

            return y;
        }

        public double GetValueForCurrentX()
        {
            return GetFunctionValue(CurrentX);
        }

        private void Solve()
        {
            double leftedge = _minValue;
            double rightEdge = _maxValue;
            double middle = (leftedge + rightEdge) / 2;
            double length = rightEdge - leftedge;

            while (length > 2 * _accuracy)
            {
                leftedge = GetFunctionValue(leftedge) * GetFunctionValue(middle) > 0 ? middle : leftedge;
                rightEdge = GetFunctionValue(rightEdge) * GetFunctionValue(middle) > 0 ? middle : rightEdge;

                middle = (leftedge + rightEdge) / 2;
                length = rightEdge - leftedge;
            }

            _solution = middle;
        }
    }
}

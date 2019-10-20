namespace HWSquare
{
    public class ArithmeticProgression
    {
        private double _a1;
        private double _d;

        public ArithmeticProgression(double a1, double d)
        {
            _a1 = a1;
            _d = d;
        }

        public double FindNElementOfProgression(double n)
        {
            n = _a1 + (n - 1) * _d;
            return n;
        }

        public double FindSumOfFirstNElements(double n)
        {
            double sum = _a1, previousA = _a1;
            for (int i = 1; i < n; i++)
            {
                var currentA = previousA + (n - 1) * _d;
                previousA = currentA;
                sum += currentA;
            }
            return sum;
        }

        public double FindAverageOfFirstNElements(double n)
        {
            var sumOfFirstNelements = FindSumOfFirstNElements(n);
            return sumOfFirstNelements / n;
        }
    }
}

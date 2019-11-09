namespace ThirdTask
{
    public class Progressions
    {
        public double MultiplyReversalProgression(double prevA, double t, double alim)
        {
            double thisA = prevA / t;
            if (thisA <= alim)
            {
                return prevA;
            }
            double nextA = MultiplyReversalProgression(thisA, t, alim);
            return prevA * nextA;
        }

        public double MultiplyArithmeticProgression(double prevA, double t, double n)
        {
            double thisA = prevA + t;
            if (n == 0)
            {
                return prevA;
            }
            double nextA = MultiplyArithmeticProgression(thisA, t, n-1);
            return prevA * nextA;
        }
    }
}

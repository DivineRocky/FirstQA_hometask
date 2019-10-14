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
    }
}

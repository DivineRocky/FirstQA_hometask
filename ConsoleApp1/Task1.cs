namespace ConsoleApp1
{
    public class Task1
    {
        public float CalculateAverage(int n, int m)
        {
            int sum = 0, amount = m - n + 1;
            for (int i = n; i <= m; i++)
            {
                sum = sum + i;
            }
            return (float) sum / amount;
        }

        public int CalculateEvenNumbersSum(int n1)
        {
            return CalculateEvenNumbersSumInRange(0, n1);
        }

        public int CalculateEvenNumbersSumInRange(int n1, int n2)
        {
            int sumInRange = 0;
            for (int i = n1; i <= n2; i++)
            {
                sumInRange += i % 2 == 0 ? i : 0;
            }
            return sumInRange;
        }
    }
}

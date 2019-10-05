using LibPrj3;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSecondTask();
            RunFirstTask();
            Console.Read();
        }

        private static void RunFirstTask()
        {
            PrintHeader();
            int n = ReadIntParameterFromConsole("n");
            int m = ReadIntParameterFromConsole("m");
            int n1 = ReadIntParameterFromConsole("n1");
            int n2 = ReadIntParameterFromConsole("n2");
            Task1 task1 = new Task1();
            float average = task1.CalculateAverage(n, m);
            Console.WriteLine($"average [{n}..{m}]: {average}");
            int evenNumbersSum = task1.CalculateEvenNumbersSum(n1);
            Console.WriteLine($"even numbers [0..{n1}] sum is: {evenNumbersSum}");
            int evenNumbersSumInRange = task1.CalculateEvenNumbersSumInRange(n1, n2);
            Console.WriteLine($"even numbers [{n1}..{n2}] sum is: {evenNumbersSumInRange}");
            PrintWait();
        }

        private static void PrintHeader()
        {
            Console.Clear();
            Console.WriteLine("FIRST TASK\n");
        }

        private static void RunSecondTask()
        {
            Console.Clear();
            Console.WriteLine("SECOND TASK\n");
            var matrix = new int[] { 10, 5, 3, 4, 9 };
            Console.WriteLine("Original marix:");
            PrintIntMatrix(matrix);
            var matrixTask = new Matrix();
            var mirrorResult = matrixTask.ArrayMirror(matrix);
            Console.WriteLine("Mirrored matrix:");
            PrintIntMatrix(mirrorResult);
            var maxElementDistance = matrixTask.GetMaxElementDistance(matrix);
            Console.WriteLine($"Max element distance: {maxElementDistance}");
            PrintWait();
        }

        private static int ReadIntParameterFromConsole(string parameterName)
        {
            Console.Write($"Enter {parameterName}: ");
            string input = Console.ReadLine();
            try
            {
                int digit = Convert.ToInt32(input);
                return digit;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input");
                return ReadIntParameterFromConsole(parameterName);
            }          
        }

        private static void PrintIntMatrix(int[] matrix)
        {
            foreach (var item in matrix)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static void PrintWait()
        {
            Console.WriteLine("Press any key to continue....");
            Console.Read();
        }
    }
}

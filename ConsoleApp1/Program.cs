using LibPrj3;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTrirdTask();
            RunSecondTask();
            RunFirstTask();
            Console.Read();
        }

        private static void RunFirstTask()
        {
            PrintHeader("FIRST TASK");
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

        private static void RunSecondTask()
        {
            PrintHeader("SECOND TASK");
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

        private static void RunTrirdTask()
        {
            PrintHeader("THIRD TASK");
            var matrix = new int[,] { { 9, 2, 3 }, { 2, 3, 5 }, { 6, 7, 4 } };
            Console.WriteLine("Original marix:");
            PrintIntMatrix(matrix);
            var matrixTask = new Matrix();
            var mirrorResult = matrixTask.FillNotDiagonalWithOne(matrix);
            Console.WriteLine("Mirrored matrix:");
            PrintIntMatrix(mirrorResult);
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

        private static void PrintIntMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintHeader(string title)
        {
            Console.Clear();
            Console.WriteLine($"{title}\n");
        }

        private static void PrintWait()
        {
            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();
        }
    }
}

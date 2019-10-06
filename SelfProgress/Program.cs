using System;

namespace SelfProgress
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSingleDimentionArray();
            Console.Read();
        }

        private static void RunSingleDimentionArray()
        {
            PrintHeader("Single Dimention Array");
            int [] matrix = new int[] { 10, 5, 3, 4, 9 };
            Console.WriteLine("Original marix:");
            PrintIntMatrix(matrix);
            var matrixTask = new SingleDimentionArray();
            float average = matrixTask.ToCountArrayAverage(matrix);
            Console.WriteLine($"Array Average:{average}");
            PrintWait();
        }

        private static void PrintIntMatrix(int[] matrix)
        {
            foreach (var item in matrix)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
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

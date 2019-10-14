using System;
using ThirdTask;

namespace SelfProgress
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSecondProgression();
            //RunSingleDimentionArray();
            Console.Read();
        }

        private static void RunSecondProgression()
        {
            PrintHeader("Reversal Progression");
            var a1 = ReadDoubleParameterFromConsole("a1");
            var t = ReadDoubleParameterFromConsole("t");
            var alim = ReadDoubleParameterFromConsole("alim");
            var progression = new Progressions();
            var multiplyResult = progression.MultiplyReversalProgression(a1, t, alim);
            Console.WriteLine($"multiply result: {multiplyResult}");
            PrintWait();
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

        private static double ReadDoubleParameterFromConsole(string parameterName)
        {
            Console.Write($"Enter {parameterName}: ");
            string input = Console.ReadLine();
            try
            {
                double digit = Convert.ToDouble(input);
                return digit;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input");
                return ReadDoubleParameterFromConsole(parameterName);
            }
        }
    }
}

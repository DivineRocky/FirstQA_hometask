using HomeWork2;
using System;
using ThirdTask;

namespace SelfProgress
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFirstProgression ();
            //RunArraySorting();
            //RunArraySortingVerification();
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
        private static void RunFirstProgression()
        {
            PrintHeader("Arithmetic Progression");
            var a1 = ReadDoubleParameterFromConsole("a1");
            var t = ReadDoubleParameterFromConsole("t");
            var n = ReadDoubleParameterFromConsole("n");
            var progression = new Progressions();
            var multiplyResult = progression.MultiplyArithmeticProgression(a1, t, n);
            Console.WriteLine($"multiply result: {multiplyResult}");
            PrintWait();
        }

        private static void RunSingleDimentionArray()
        {
            PrintHeader("Single Dimention Array");
            int [] matrix = new int[] { 10, 5, 3, 4, 9 };
            Console.WriteLine("Original matrix:");
            PrintIntMatrix(matrix);
            var matrixTask = new SingleDimentionArray();
            float average = matrixTask.MultiplyArrayElements(matrix);
            Console.WriteLine($"Array Average:{average}");
            int multiplication = matrixTask.MultiplyArrayElements(matrix);
            Console.WriteLine($"Array Multiplication:{multiplication}");
            PrintWait();
        }

        private static void RunArraySorting()
        {
            PrintHeader("Sorting Array");
            int[] mas = new int[] { 10, 5, 3, 4, 9 };
            Console.WriteLine("Original mas:");
            PrintIntMatrix(mas);
            var masTask = new ArraySorting();
            int [] ascSortedArray = masTask.SortArray(mas, SortingOrder.Asc);
            Console.WriteLine($"Sorted by Asc");
            PrintIntMatrix(ascSortedArray);
            int[] descSortedArray = masTask.SortArray(mas, SortingOrder.Desc);
            Console.WriteLine($"Sorted by Desc");
            PrintIntMatrix(descSortedArray);
            PrintWait();
        }
        private static void RunArraySortingVerification()
        {
            PrintHeader("Sorting Array Verification");
            int[] mas = new int[] { 10, 5, 3, 4, 9 };
            Console.WriteLine("Original mas:");
            PrintIntMatrix(mas);
            var masTask = new ArraySorting();
            int[] ascSortedArray = masTask.SortArray(mas, SortingOrder.Asc);         
            int[] descSortedArray = masTask.SortArray(mas, SortingOrder.Desc);
            bool VerifySortedArrayAsc = masTask.ValidateArraySorting(ascSortedArray, SortingOrder.Asc);
            Console.WriteLine($"Sorted by Asc:{VerifySortedArrayAsc}");
            bool VerifySortedArrayDesc = masTask.ValidateArraySorting(descSortedArray, SortingOrder.Desc);
            Console.WriteLine($"Sorted by Desc:{VerifySortedArrayDesc}");
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

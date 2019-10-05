using LibPrj3;
using System;

namespace ConsolPrj1
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new int[] {10, 5, 3, 4};
            var digitMirror = new Matrix();
            var mirrorResult = digitMirror.ArrayMirror(matrix);
            Console.Read();
        }
    }
}

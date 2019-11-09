using System;

namespace HWork6
{
    public class SmartMatrix: IEquatable<SmartMatrix>
    {
        public SmartMatrix(int[] matrix)
        {
            Matrix = matrix;
        }

        public int[] Matrix { get; }     

        public static SmartMatrix operator +(SmartMatrix firstMatrix, SmartMatrix secondMatrix)
        {
            int[] result;
            if (!VerifySameSize(firstMatrix, secondMatrix))
                throw new ArgumentException("Matrixes are of different size");
            result = new int[firstMatrix.Matrix.Length];
            for (int i = 0; i < firstMatrix.Matrix.Length; i++)
            {
                result[i] = firstMatrix.Matrix[i] + secondMatrix.Matrix[i];
            }
            return new SmartMatrix(result);
        }

        public static SmartMatrix operator -(SmartMatrix firstMatrix, SmartMatrix secondMatrix)
        {
            int[] result;
            if (!VerifySameSize(firstMatrix, secondMatrix))
                throw new ArgumentException("Matrixes are of different size");
            result = new int[firstMatrix.Matrix.Length];
            for (int i = 0; i < firstMatrix.Matrix.Length; i++)
            {
                result[i] = firstMatrix.Matrix[i] - secondMatrix.Matrix[i];
            }
            return new SmartMatrix(result);
        }

        public static int operator *(SmartMatrix firstMatrix, SmartMatrix secondMatrix)
        {
            int result = 0;
            if (!VerifySameSize(firstMatrix, secondMatrix))
                throw new ArgumentException("Matrixes are of different size");
           
            for (int i = 0; i < firstMatrix.Matrix.Length; i++)
            {
                result = result + firstMatrix.Matrix[i] * secondMatrix.Matrix[i];
            }
            return result;
        }

        public bool Equals(SmartMatrix other)
        {
            if (!VerifySameSize(this, other))
                return false;
            for (int i = 0; i < this.Matrix.Length; i++)
            {
                if (this.Matrix[i] != other.Matrix[i])
                {
                    return false;
                }               
            }
            return true;
        }

        private static bool VerifySameSize(SmartMatrix firstMatrix, SmartMatrix secondMatrix)
        {
            bool lengthMatch = firstMatrix.Matrix.Length == secondMatrix.Matrix.Length;
            return lengthMatch;
        }       
    }
}

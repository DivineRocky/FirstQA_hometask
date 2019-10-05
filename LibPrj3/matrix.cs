using System;

namespace LibPrj3
{
    public class Matrix
    {
        public int[] ArrayMirror(int[] arrayToMirror)
        {
            int middleArrayIndex = arrayToMirror.Length / 2;
            for (int i = 0; i < middleArrayIndex; i++)
            {
                int lastArrayIndex = arrayToMirror.Length - i - 1;
                var elementAtLastIndex = arrayToMirror[lastArrayIndex];
                arrayToMirror[lastArrayIndex] = arrayToMirror[i];
                arrayToMirror[i] = elementAtLastIndex;
            }       
            return arrayToMirror;
        }

        public int[,] FillNotDiagonalWithOne(int[,] inputArray)
        {
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    if (i > j)
                    {
                        inputArray[i, j] = 0;
                    }
                    if (i < j)
                    {
                        inputArray[i, j] = 1;
                    }
                }
            }
            return inputArray;
        }

        public int GetMaxElementDistance(int[] startArray)
        {
            var startArrayMaxElementIndex = GetMaxElementIndexFromBegining(startArray);
            var mirroredArryaMaxElementIndex = GetMaxElementIndexFromEnd(startArray);
            return Math.Abs(startArrayMaxElementIndex - mirroredArryaMaxElementIndex);
        }

        private int GetMaxElementIndexFromBegining(int[] array)
        {
            var index = 0;
            var max = array[index];
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            return index;
        }

        private int GetMaxElementIndexFromEnd(int[] array)
        {
            var index = array.Length - 1;
            var max = array[index];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            return index;
        }
    }
}

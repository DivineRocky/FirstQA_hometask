using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    public class ArraySorting : IArraySorting
    {
        public int[] SortArray(int[] array, SortingOrder order)
        {
            int[] arrayCopy = new int[array.Length];
            array.CopyTo(arrayCopy, 0);
            switch (order)
            {
                case SortingOrder.Asc:
                    return SortArrayAsc(arrayCopy);

                case SortingOrder.Desc:
                    return SortArrayDesc(arrayCopy);
            }
            throw new ArgumentException("Invalid argument");
        }

        public bool ValidateArraySorting(int[] array, SortingOrder order)
        {
            int[] arrayCopy = new int[array.Length];
            array.CopyTo(arrayCopy, 0);
            switch (order)
            {
                case SortingOrder.Asc:
                    return VerifySortedArrayAsc(arrayCopy);

                case SortingOrder.Desc:
                    return VerifySortedArrayDesc(arrayCopy);
            }
            throw new ArgumentException("Invalid argument");
        }

        private int[] SortArrayAsc(int[] array)
        {
            int temp;     
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        private int[] SortArrayDesc(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        private bool VerifySortedArrayAsc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool VerifySortedArrayDesc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }

}

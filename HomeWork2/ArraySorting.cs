using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    public class ArraySorting
    {
        public int[] SortArray(int[] array, SortingOrder order)
        {
            switch(order)
            {
                case SortingOrder.Asc:
                    return SortArrayAsc(array);

                case SortingOrder.Desc:
                    return SortArrayDesc(array);
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
    }
}

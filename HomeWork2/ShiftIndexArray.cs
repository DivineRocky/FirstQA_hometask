using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    public class ShiftIndexArray<T>
    {
        private readonly int indexShift;
        private T[] array;

        public ShiftIndexArray(int indexShift, int lenght) 
        {
            this.indexShift = indexShift;
            array = new T[lenght];
        }

        public int GetLength => array.Length;

        public int GetLowerBound => indexShift;

        public int GetUpperBound => indexShift + array.Length;

        public T this[int key]
        {
            get => array[key + indexShift];
            set => array[key + indexShift] = value;
        }
    }
}

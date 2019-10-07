using System;
using System.Collections.Generic;
using System.Text;

namespace SelfProgress 
{
    public class SingleDimentionArray
    {
        public float ToCountArrayAverage(int[] inputArray)
        {
            int sum = 0;
            int amount = inputArray.Length;
            foreach(int item in inputArray)
            {
                sum = sum + item;
            }
            return (float) sum / amount;
        }

        public int ToCountArrayMultiplication(int[] inputArray)
        {
            int sum = 1;
            foreach(int item in inputArray)
            {
                sum = sum * item;
            }
            return sum;
        }

    }

}

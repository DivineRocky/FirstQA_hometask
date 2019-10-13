using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2
{
    public interface IArraySorting
    {
        int[] SortArray(int[] array, SortingOrder order);

        bool ValidateArraySorting(int[] array, SortingOrder order);
    }
}

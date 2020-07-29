using System;

namespace Preparationkit.Algorithms.Sorters
{
    public class InsertionSorter : ISorter
    {
        /// <summary>
        /// - It is efficient for smaller data sets, but very inefficient for larger lists.
        /// - Insertion Sort is adaptive, that means it reduces its total number of steps
        ///    if a partially sorted array is provided as input, making it efficient.
        /// - It is better than Selection Sort and Bubble Sort algorithms.
        /// - Its space complexity is less.Like bubble Sort, insertion sort also requires
        ///    a single additional memory space.
        /// - It is a stable sorting technique, as it does not change the relative order of
        ///    elements which are equal.
        /// Time complexity: O(n^2). Best case - O(n)
        /// Space complexity: O(1)
        /// </summary>
        /// <param name="array"></param>
        public void Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (var i = 1; i < array.Length; i++)
            {
                int j = 0;
                while (j < i && array[j] <= array[i])
                {
                    j++;
                }
                if (j != i)
                {
                    var tmp = array[j];
                    array[j] = array[i];
                    array[i] = tmp;
                }
            }
        }
    }
}

using System;

namespace Preparationkit.Algorithms.Sorters
{
    public class MergeSorter : ISorter
    {
        private void Merge(int[] array, int start, int half, int end)
        {
            var tmp = new int[array.Length];

            int i = start, j = half + 1, k = 0;
            while (i <= half && j <= end)
            {
                tmp[k++] = array[i] < array[j] ? array[i++] : array[j++];
            }
            while (i <= half)
            {
                tmp[k++] = array[i++];
            }
            while (j <= end)
            {
                tmp[k++] = array[j++];
            }

            k = 0;
            for (i = start; i <= end; i++)
            {
                array[i] = tmp[k++];
            }
        }

        private void DivideAndSort(int[] array, int start, int end)
        {
            int half = (start + end) / 2;

            if (start < end)
            {
                DivideAndSort(array, start, half);
                DivideAndSort(array, half + 1, end);
                Merge(array, start, half, end);
            }
        }

        /// <summary>
        /// A quite fast and stable sort, which means the "equal" elements are ordered in the same order in the sorted list.
        /// Whenever we divide a number into half in every step, it can be represented using a logarithmic function,
        ///   which is log n and the number of steps can be represented by log n + 1(at most)
        ///   Also, we perform a single step operation to find out the middle of any subarray, i.e.O(1).
        ///   And to merge the subarrays, made by dividing the original array of n elements, a running time of O(n) will be required.
        /// It requires equal amount of additional space as the unsorted array. Hence its not at all recommended for searching large unsorted arrays.
        /// Time complexity: O(n*log(n))
        /// Space complexity: O(n)
        /// </summary>
        /// <param name="array"></param>
        public void Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            DivideAndSort(array, 0, array.Length - 1);
        }
    }
}

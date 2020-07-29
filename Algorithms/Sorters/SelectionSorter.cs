using System;

namespace Preparationkit.Algorithms.Sorters
{
    public class SelectionSorter : ISorter
    {
        private void Swap(int[] array, int fromIndex, int toIndex)
        {
            var tmp = array[toIndex];
            array[toIndex] = array[fromIndex];
            array[fromIndex] = tmp;
        }

        private int FindMinimunIndex(int[] array, int startIndex)
        {
            int result = startIndex;
            for (var i = startIndex+1; i < array.Length; i++)
            {
                if (array[i] < array[result])
                    result = i;
            }
            return result;
        }

        /// <summary>
        /// Requires two nested for loops to complete itself
        /// Time complexity: O(n^2)
        /// Space complexity: O(1)
        /// </summary>
        /// <param name="array"></param>
        public void Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            for (var i = 0; i < array.Length; i++)
            {
                var index = FindMinimunIndex(array, i);
                Swap(array, i, index);
            }
        }
    }
}

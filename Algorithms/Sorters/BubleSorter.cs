using System;

namespace Preparationkit.Algorithms.Sorters
{
    public class BubbleSorter : ISorter
    {
        /// <summary>
        /// (n-1) + (n-2) + (n-3) + ..... + 3 + 2 + 1
        ///  Sum = n(n-1)/2
        ///  Time complexity: O(n^2) (O(n) when array is alerady sorted)
        ///  Space complexity: O(1)
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
                for (var j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var tmp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }

        public void OptimizedSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            bool isSwapped = false;
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var tmp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tmp;
                        isSwapped = true;
                    }
                }

                if (!isSwapped)
                {
                    break;
                }
            }
        }
    }
}

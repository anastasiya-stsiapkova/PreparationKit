using System;
using Preparationkit.Algorithms.Sorters;

namespace Preparationkit.Algorithms
{
    public class Program
    {
        private static ISorter _sorter = null;

        private static void InitSorter()
        {

            Console.Write("Select sorting algorithm by entering the number from the following:\n" +
                                "1. Buble Sort;\n" +
                                "2. Insertion Sort;\n" +
                                "3. Selection Sort;\n" +
                                "4. Merge Sort;\n" +
                                "5. Exit\n\n" +
                                "Your input: ");
            var isInputCorrect = int.TryParse(Console.ReadLine(), out var algorithmIndex);
            ValidateInput(isInputCorrect);

            if (algorithmIndex == 5)
            {
                return;
            }

            _sorter = ChooseSorter(algorithmIndex);
            ValidateInput(_sorter != null);
        }

        private static ISorter ChooseSorter(int index) =>
            index switch
            {
                1 => new BubbleSorter(),
                2 => new InsertionSorter(),
                3 => new SelectionSorter(),
                4 => new MergeSorter(),
                _ => null
            };

        private static void ValidateInput(bool isValid)
        {
            if (!isValid)
            {
                Console.WriteLine("Invalid selection. Try again!\n");
                InitSorter();
            }
        }

        public static void Main(string[] args)
        {
            InitSorter();
            if (_sorter == null)
                return;

            Console.Write("Enter array numbers splitted with ' ' (space): ");
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));


            _sorter.Sort(ar);

            Console.Write("Result: ");
            foreach (var item in ar)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }

        
    }
}
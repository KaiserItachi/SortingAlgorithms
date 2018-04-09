using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                string temp= Console.ReadLine();
                array[i] = Convert.ToInt32(temp);
                temp = null;
            }

            int[] sortedArray = MergeSort(array);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.WriteLine(sortedArray[i]);
            }

        }

        private static int[] MergeSort(int[] array)
        {
            int middle = array.Length / 2;
            int rem = array.Length - middle;
            int[] left = new int[middle];
            int[] right = new int[rem];

            if (middle > 1)
            {
                for (int i = 0; i < middle; i++)
                {
                    left[i] = array[i];
                }
            }
            else
                return array;

            if (rem > 1)
            {
                int j = 0;
                for (int i = middle; i < array.Length; i++)
                {
                    right[j] = array[i];
                    j++;
                }
            }
            else
                return array;
                        
            int[] sortedArray = new int[array.Length];
            MergeSort(left);
            MergeSort(right);
            Merge(left, right, sortedArray);
            return sortedArray;
        }

        private static void Merge(int[] left, int[] right, int[] sortedArray)
        {
            int lenghtl = left.Length;
            int lenghtr = right.Length;
            int sortedIndex = 0;
            int leftIndex = 0;
            int rightIndex = 0;

            while(leftIndex<lenghtl && rightIndex < lenghtr)
            {
                if(left[leftIndex]< right[rightIndex])
                {
                    sortedArray[sortedIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    sortedArray[sortedIndex] = right[rightIndex];
                    rightIndex++;
                }
                sortedIndex++;
            }
            while(leftIndex<lenghtl)
            {
                sortedArray[sortedIndex] = left[leftIndex];
                leftIndex++;
                sortedIndex++;
            }
            while (rightIndex < lenghtr)
            {
                sortedArray[sortedIndex] = right[rightIndex];
                rightIndex++;
                sortedIndex++;
            }

        }
    }
}

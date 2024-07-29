namespace AmrAmin.Algorithms.SortingAlgorithms.NonComparisonBasedSort;
using System.Linq;

public static class CountingSort
{
    public static void Sort(int[] array)
    {
        Utils.Utils.PrintArrayHeader(algorithmName: " Counting Sort Algorithm");
        Utils.Utils.PrintArray(array: array, arrayDescription: "Array to sort:");


        int n = array.Length;

        // Find the maximum element in the input array
        int max = array.Max();

        // Initialize the count array as 0
        int[] count = new int[max + 1];
        for (int i = 0; i < max + 1; ++i)
        {
            count[i] = 0;
        }

        // Store the count of each element in the input array
        for (int i = 0; i < n; ++i)
        {
            count[array[i]]++;
        }

        // Modify the count array by replacing each element with the sum of the previous elements
        for (int i = 1; i <= max; ++i)
        {
            count[i] += count[i - 1];
        }

        // Create a new array with the same size as the input array
        int[] output = new int[n];

        // Iterate through the input array and place the element at the index calculated from the count array
        for (int i = n - 1; i >= 0; i--)
        {
            output[count[array[i]] - 1] = array[i];
            count[array[i]]--;
        }

        // Overwrite the input array with the sorted output array
        for (int i = 0; i < n; i++)
        {
            array[i] = output[i];
        }

        Utils.Utils.PrintArray(array: array, arrayDescription: "Sorted array");
        Utils.Utils.PrintArrayFooter();

    }
}

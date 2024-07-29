namespace AmrAmin.Algorithms.SortingAlgorithms.NonComparisonBasedSort.CountingSort;
using System.Linq;

public static class CountingSort
{
    public static void Sort(int[] array)
    {
        Utils.Utils.PrintArrayHeader(algorithmName: " Counting Sort Algorithm");
        Utils.Utils.PrintArray(array: array, arrayDescription: "Array to sort:");


        int[] counts = new int[array.Max() + 1];

        foreach (var item in array)
        {
            counts[item]++;
        }

        var k = 0;
        for (int i = 0; i < counts.Length; i++)
        {
            for (int j = 0; j < counts[i]; j++)
            {
                array[k++] = i;
            }
        }

        Utils.Utils.PrintArray(array: array, arrayDescription: "Sorted array");
        Utils.Utils.PrintArrayFooter();

    }
}

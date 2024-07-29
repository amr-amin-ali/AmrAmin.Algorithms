namespace AmrAmin.Algorithms.SortingAlgorithms.NonComparisonBasedSort.BucketSort;
using System.Collections.Generic;

public static class BucketSort
{

    public static void Sort(float[] array, int numberOfBuckets)
    {
        Utils.Utils.PrintArrayHeader(algorithmName: "Bucket Sort Algorithm");
        Utils.Utils.PrintArray(array: array, arrayDescription: "Array to sort:");

        List<List<float>> buckets = CreateBuckets(array: array, numberOfBuckets: numberOfBuckets);

        int i = 0;
        foreach (var buckket in buckets)
        {
            // sort the buckket
            buckket.Sort((a, b) => a.CompareTo(b));
            // insert into the main array
            foreach (var item in buckket)
            {
                array[i++] = item;
            }
        }


        Utils.Utils.PrintArray(array: array, arrayDescription: "Sorted array");
        Utils.Utils.PrintArrayFooter();

    }

    private static List<List<float>> CreateBuckets(float[] array, int numberOfBuckets)
    {
        List<List<float>> buckets = new List<List<float>>();

        // Initialize the buckets
        for (int i = 0; i <= numberOfBuckets; i++)
        {
            buckets.Add(new List<float>());
        }

        foreach (var item in array)
        {
            var i = (int)item / numberOfBuckets;
            buckets[i].Add(item);
        }

        return buckets;
    }
}

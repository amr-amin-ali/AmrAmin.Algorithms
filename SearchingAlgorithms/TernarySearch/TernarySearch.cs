namespace AmrAmin.Algorithms.SearchingAlgorithms.TernarySearch;
using AmrAmin.Algorithms.Utils;

public static class TernarySearch
{
    public static int Search(int[] arr, int target)
    {
        SearchingUtils.PrintSearchHeader(" Ternary Search");
        SearchingUtils.PrintArray(arr, "Array to search in:");
        SearchingUtils.PrintTarget(target);

        var result = TernarySearchAlgorithm(arr, target, 0, arr.Length - 1);


        SearchingUtils.PrintResult(result);
        SearchingUtils.PrintArrayFooter();
        return -1;
    }

    private static int TernarySearchAlgorithm(int[] array, int target, int left, int right)
    {
        // Recursion stopping condition
        if (left > right)
        {
            return -1;
        }

        // first: calculate the middle points
        var partitionSize = (right - left) / 3;
        var mid1 = left + partitionSize;
        var mid2 = right - partitionSize;

        if (array[mid1] == target)
        {
            return mid1;
        }
        if (array[mid2] == target)
        {
            return mid2;
        }

        if (target < array[mid1])
        {
            return TernarySearchAlgorithm(array, target, left, mid1 - 1);
        }
        if (target > array[mid2])
        {
            return TernarySearchAlgorithm(array, target, mid2 + 1, right);
        }
        return TernarySearchAlgorithm(array, target, mid1 + 1, mid2 - 1);
    }
}

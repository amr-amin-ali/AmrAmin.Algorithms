namespace AmrAmin.Algorithms.SearchingAlgorithms.BinarySearch;
using AmrAmin.Algorithms.Utils;

public static class BinarySearchRecursive
{
    public static void Search(int[] array, int target)
    {
        SearchingUtils.PrintSearchHeader(" Binary Search Recursive");
        SearchingUtils.PrintArray(array, "Array to search in:");
        SearchingUtils.PrintTarget(target);

        var result = RecursiveBinarySearchRecursive(array: array, target: target, leftIndex: 0, rightIndex: array.Length - 1);

        SearchingUtils.PrintResult(result);
        SearchingUtils.PrintArrayFooter();

    }

    private static int RecursiveBinarySearchRecursive(int[] array, int target, int leftIndex, int rightIndex)
    {

        if (leftIndex > rightIndex)
        {
            return -1; // Target not found
        }

        int middle = (leftIndex + rightIndex) / 2;

        if (array[middle] == target)
        {
            return middle; // Target found
        }
        else if (array[middle] > target)
        {
            return RecursiveBinarySearchRecursive(array: array, target: target, leftIndex: leftIndex, rightIndex: middle - 1); // Target is in the left half
        }
        else
        {
            return RecursiveBinarySearchRecursive(array: array, target: target, leftIndex: middle + 1, rightIndex: rightIndex); // Target is in the right half
        }
    }
}

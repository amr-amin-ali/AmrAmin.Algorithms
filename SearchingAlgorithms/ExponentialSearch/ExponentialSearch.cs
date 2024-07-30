namespace AmrAmin.Algorithms.SearchingAlgorithms.ExponentialSearch;

using AmrAmin.Algorithms.Utils;

public static class ExponentialSearch
{
    public static void Search(int[] arr, int target)
    {
        SearchingUtils.PrintSearchHeader(" Exponential Search");
        SearchingUtils.PrintArray(arr, "Array to search in:");
        SearchingUtils.PrintTarget(target);
        // Step 1: Initialize the search range
        int bound = 1;
        while (bound < arr.Length && arr[bound] <= target)
        {
            bound *= 2;
        }

        // Step 2: Perform Binary Search within the identified range
        int left = bound / 2;
        int right = Math.Min(bound, arr.Length - 1);
        var result = BinarySearch(arr, target, left, right);

        SearchingUtils.PrintResult(result);
        SearchingUtils.PrintArrayFooter();
    }
    private static int BinarySearch(int[] arr, int target, int left, int right)
    {
        while (left <= right)
        {
            int mid = left + ((right - left) / 2);
            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1; // Target value not found
    }
}

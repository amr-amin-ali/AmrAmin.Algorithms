namespace AmrAmin.Algorithms.SearchingAlgorithms.JumpSearch;

using AmrAmin.Algorithms.Utils;

public static class JumpSearch
{
    public static void Search(int[] arr, int target)
    {
        SearchingUtils.PrintSearchHeader(" Jump Search");
        SearchingUtils.PrintArray(arr, "Array to search in:");
        SearchingUtils.PrintTarget(target);

        int blockSize = (int)Math.Sqrt(arr.Length);
        int start = 0;
        int next = blockSize - 1;

        // Find the correct block
        while (next < arr.Length && arr[next] <= target)
        {
            if (start >= arr.Length)
            {
                break;

            }
            start = next;
            next += blockSize;
        }
        int result = -1;
        // Perform linear search within the block
        for (int i = start; i <= Math.Min(next, arr.Length - 1); i++)
        {
            if (arr[i] == target)
            {
                result = i;
                break;
            }
        }

        SearchingUtils.PrintResult(result);// Target value not found
        SearchingUtils.PrintArrayFooter();
    }
}

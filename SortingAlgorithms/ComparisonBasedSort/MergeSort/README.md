# Merge Sort Algorithm

Merge Sort is a divide-and-conquer algorithm that recursively divides an array into smaller subarrays, sorts them, and then merges them back together to form the final sorted array.

## How it Works

1. Divide the unsorted array into two halves, until you have subarrays of size 1.
2. Merge the subarrays by comparing the elements and sorting them in ascending order.
3. Repeat step 2 until the entire array is sorted.

The algorithm gets its name from the way it "merges" the sorted subarrays back together to form the final sorted array.

## Code Example

Here's an example implementation of the Merge Sort algorithm in C#:

```csharp
public static void MergeSort(int[] arr)
{
    if (arr.Length > 1)
    {
        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        for (int i = 0; i < mid; ++i)
            left[i] = arr[i];
        for (int i = mid; i < arr.Length; ++i)
            right[i - mid] = arr[i];

        MergeSort(left);
        MergeSort(right);

        Merge(arr, left, right);
    }
}

private static void Merge(int[] arr, int[] left, int[] right)
{
    int i = 0, j = 0, k = 0;
    while (i < left.Length && j < right.Length)
    {
        if (left[i] <= right[j])
            arr[k++] = left[i++];
        else
            arr[k++] = right[j++];
    }

    while (i < left.Length)
        arr[k++] = left[i++];

    while (j < right.Length)
        arr[k++] = right[j++];
}
```

The `MergeSort` method takes an integer array `arr` as input and sorts it in ascending order using the Merge Sort algorithm. The `Merge` method is a helper method that merges the sorted subarrays back together.

## Usage Example

Here's an example of how to use the `MergeSort` method:

```csharp
int[] numbers = { 5, 2, 8, 1, 9 };
MergeSort(numbers);

// The numbers array is now sorted: { 1, 2, 5, 8, 9 }
```

You can call the `MergeSort` method with any integer array, and it will sort the array in ascending order.

## Time Complexity

The time complexity of Merge Sort is shown in the following table:

| Metric     | Best Case | Worst Case |
|------------|-----------|------------|
| Dividing   | O(log n)  | O(log n)   |
| Merging    | O(n)       | O(n)       |
| Total      | O(n log n) | O(n log n) |
| Complexity | Linear     | Linear     |

Merge Sort has a time complexity of O(n log n) for both the best and worst cases, making it an efficient sorting algorithm, especially for large datasets. The algorithm's performance is not affected by the initial order of the input array.
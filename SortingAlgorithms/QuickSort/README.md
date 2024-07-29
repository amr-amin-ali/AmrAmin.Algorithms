# Quick Sort Algorithm

Quick Sort is a highly efficient sorting algorithm that follows the divide-and-conquer paradigm. It works by selecting a 'pivot' element from the array, and partitioning the other elements into two sub-arrays, according to whether they are less than or greater than the pivot.

## How it Works

1. Choose a 'pivot' element from the array.
2. Partition the other elements into two sub-arrays, according to whether they are less than or greater than the pivot.
3. Recursively apply the same process to the sub-arrays.

The key steps in the Quick Sort algorithm are:

1. **Pivot Selection**: The choice of the pivot element is crucial to the performance of the algorithm. There are three common methods for selecting the pivot:
   - **Pick randomly**: Randomly selecting the pivot element can help avoid the worst-case scenario where the array is already sorted (or reverse-sorted), which would lead to a time complexity of O(n^2).
   - **Use the middle index**: Selecting the middle element as the pivot can also help avoid the worst-case scenario, as it is less likely to be the smallest or largest element in the array.
   - **Average of first, middle, and last item**: Taking the average of the first, middle, and last elements can help select a pivot that is closer to the median of the array, leading to more balanced partitions.

2. **Partitioning**: The partitioning step involves rearranging the elements in the array such that all elements less than the pivot are moved to the left side, and all elements greater than the pivot are moved to the right side. This is typically done using two pointers, one starting from the beginning and one from the end of the array.

3. **Recursion**: After the partitioning step, the algorithm recursively applies the same process to the left and right sub-arrays, until the entire array is sorted.

## Code Example

Here's an example implementation of the Quick Sort algorithm in C#:

```csharp
public static void QuickSort(int[] arr, int low, int high)
{
    if (low < high)
    {
        int pi = Partition(arr, low, high);

        QuickSort(arr, low, pi - 1);
        QuickSort(arr, pi + 1, high);
    }
}

private static int Partition(int[] arr, int low, int high)
{
    int pivot = arr[high];
    int i = (low - 1);

    for (int j = low; j < high; j++)
    {
        if (arr[j] < pivot)
        {
            i++;
            Swap(arr, i, j);
        }
    }

    Swap(arr, i + 1, high);
    return i + 1;
}

private static void Swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}
```

The `QuickSort` method takes an integer array `arr`, and the low and high indices of the sub-array to be sorted. The `Partition` method is a helper method that partitions the sub-array around the pivot element.

## Usage Example

Here's an example of how to use the `QuickSort` method:

```csharp
int[] numbers = { 5, 2, 8, 1, 9 };
QuickSort(numbers, 0, numbers.Length - 1);

// The numbers array is now sorted: { 1, 2, 5, 8, 9 }
```

You can call the `QuickSort` method with any integer array, and it will sort the array in ascending order.

## Time Complexity

The time complexity of Quick Sort is shown in the following table:

| Metric     | Best Case | Worst Case |
|------------|-----------|------------|
| Partitioning | O(n)     | O(n)       |
| # of times  | O(log n)  | O(n)       |
| Total      | O(n log n) | O(n^2)     |
| Space      | O(log n)  | O(n)       |

The best-case scenario for Quick Sort occurs when the pivot element is always the median of the array, leading to a balanced partition and a time complexity of O(n log n). The worst-case scenario occurs when the array is already sorted (or reverse-sorted), and the pivot element is always the smallest or largest element, leading to a time complexity of O(n^2).

To avoid the worst-case scenario, it's important to choose the pivot element carefully. The image presents three common methods for selecting the pivot: picking randomly, using the middle index, and taking the average of the first, middle, and last elements.

Overall, Quick Sort is a highly efficient algorithm that is widely used in practice, especially for large datasets, due to its average-case time complexity of O(n log n).
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
public static class QuickSort
{
    public static void Sort(int[] array)
    {
        Utils.Utils.PrintArrayHeader(algorithmName: "  Quick Sort Algorithm  ");
        Utils.Utils.PrintArray(array: array, arrayDescription: "Array to sort:");
        int start = 0;
        int end = array.Length - 1;
        QuickSortAlgorithm(array, start, end);

        Utils.Utils.PrintArray(array: array, arrayDescription: "Sorted array");
        Utils.Utils.PrintArrayFooter();

    }

    private static void QuickSortAlgorithm(int[] array, int start, int end)
    {

        /*First we need to partition this array
         *  as a part of partitioning, the PIVOT which we assume is the last element in this array
         *  is going to move to it's right partition, then we gety the position of the PIVOT and from there
         *  we will recursively sort the left and right partition
         */

        // 0. condition to break the recursion
        if (start >= end)
        {
            return;
        }
        // 1. Partition
        var boundary = Partition(array: array, start: start, end: end);
        // 2. Sort left 
        QuickSortAlgorithm(array, start, boundary - 1);
        // 3. Sort right
        QuickSortAlgorithm(array, boundary + 1, end);



    }
    /// <summary>Implements the partitioning part of the algorithm.</summary>
    /// <returns>The index of the PIVOT after it has moved to it's right position.</returns>
    private static int Partition(int[] array, int start, int end)
    {
        // let's assume that the PIVOT is the last element in this array.
        var pivot = array[end];
        // we also need a variable and set it's value to -1 which mean that the left partition is empty.
        var boundary = start - 1;
        // now iterate over the array and if we found an item smaller than the PIVOT, we put it in the left partition.
        for (int i = start; i <= end; i++)
        {
            if (array[i] <= pivot)
            {
                //boundary++;
                //Swap(array, i, boundary);
                Swap(array, i, ++boundary);
            }
        }
        return boundary;
    }
    private static void Swap(int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}


```

The `QuickSortAlgorithm` method takes an integer array `array`, and the low and high indices of the sub-array to be sorted. The `Partition` method is a helper method that partitions the sub-array around the pivot element.

## Usage Example

Here's an example of how to use the `QuickSortAlgorithm` method:

```csharp
int[] quickSortArray = [1, 9, 5, 6, 3, 7, 4, 2, 8];
QuickSort.Sort(quickSortArray);

// The numbers array is now sorted: { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
```

You can call the `Sort` method with any integer array, and it will sort the array in ascending order.

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
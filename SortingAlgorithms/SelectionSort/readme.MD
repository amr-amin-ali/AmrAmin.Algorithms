# Selection Sort Algorithm

Selection Sort is a simple sorting algorithm that works by repeatedly finding the minimum element from the unsorted part of the array and swapping it with the first element of the unsorted part. This process is repeated until the entire array is sorted.

## How it Works

1. Find the minimum element in the unsorted part of the array.
2. Swap the minimum element with the first element of the unsorted part.
3. Repeat steps 1 and 2 for the remaining unsorted part of the array.

The algorithm gets its name from the way it "selects" the minimum element from the unsorted part of the array.

## Code Example

Here's an example implementation of the Selection Sort algorithm in C#:

```csharp
public static void SelectionSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[minIndex])
            {
                minIndex = j;
            }
        }

        // Swap the found minimum element with the first element
        int temp = arr[minIndex];
        arr[minIndex] = arr[i];
        arr[i] = temp;
    }
}
```

The `SelectionSort` method takes an integer array `arr` as input and sorts it in ascending order using the Selection Sort algorithm.

## Usage Example

Here's an example of how to use the `SelectionSort` method:

```csharp
int[] numbers = { 5, 2, 8, 1, 9 };
SelectionSort(numbers);

// The numbers array is now sorted: { 1, 2, 5, 8, 9 }
```

You can call the `SelectionSort` method with any integer array, and it will sort the array in ascending order.

## Time Complexity

The time complexity of Selection Sort is shown in the following table:

| Metric     | Best Case | Worst Case |
|------------|-----------|------------|
| Passes     | O(n)       | O(n)       |
| Comparisons| O(n)       | O(n)       |
| Total      | O(n^2)     | O(n^2)     |
| Complexity | Quadratic  | Quadratic  |

The best-case and worst-case scenarios both have a quadratic time complexity, making Selection Sort less efficient for large datasets compared to other sorting algorithms like Quicksort, Mergesort, or Heapsort.

However, Selection Sort is simple to implement and can be useful in certain situations, such as when the input array is small or when the cost of swapping elements is high compared to the cost of comparisons.
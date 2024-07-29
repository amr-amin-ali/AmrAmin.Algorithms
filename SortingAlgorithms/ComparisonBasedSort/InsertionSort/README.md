# Insertion Sort Algorithm

Insertion Sort is a simple sorting algorithm that builds the final sorted array (or list) one item at a time. It works by iterating through the array, removing one element at a time, and inserting it into the correct position in the sorted portion of the array.


## How it Works

1. Iterate through the array from the second element to the last element.
2. For each element, compare it with the elements in the sorted portion of the array (the elements before the current element).
3. Insert the element into the correct position in the sorted portion of the array.
4. Repeat steps 2 and 3 for the remaining elements in the array.

The algorithm gets its name from the way it "inserts" each element into the correct position in the sorted portion of the array.

## Code Example

Here's an example implementation of the Insertion Sort algorithm in C#:

```csharp
public static void InsertionSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 1; i < n; ++i)
    {
        int key = arr[i];
        int j = i - 1;

        // Move elements of arr[0..i-1], that are greater than key, to one position ahead of their current position
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }
}
```

The `InsertionSort` method takes an integer array `arr` as input and sorts it in ascending order using the Insertion Sort algorithm.

## Usage Example

Here's an example of how to use the `InsertionSort` method:

```csharp
int[] numbers = { 5, 2, 8, 1, 9 };
InsertionSort(numbers);

// The numbers array is now sorted: { 1, 2, 5, 8, 9 }
```

You can call the `InsertionSort` method with any integer array, and it will sort the array in ascending order.

## Time Complexity

The time complexity of Insertion Sort is shown in the following table:

| Metric     | Best Case | Worst Case |
|------------|-----------|------------|
| Iteration  | O(n)       | O(n)       |
| Shift items| O(1)       | O(n)       |
| Total      | O(n)       | O(n^2)     |
| Complexity | Linear     | Quadratic  |

The best-case scenario has a linear time complexity, while the worst-case scenario has a quadratic time complexity.

Insertion Sort is efficient for small or nearly-sorted arrays, but it has a higher time complexity compared to more advanced sorting algorithms like Quicksort, Mergesort, or Heapsort, especially for larger arrays.
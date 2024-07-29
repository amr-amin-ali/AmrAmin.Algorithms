# Counting Sort Algorithm

Counting Sort is a simple sorting algorithm that works by counting the number of occurrences of each unique element in the input array. It then builds a output array by placing the elements in sorted order.

## When to Use Counting Sort

Counting Sort is most effective when the range of input values is not significantly greater than the number of elements in the input array. It is particularly useful in the following scenarios:

1. **Small Range of Input Values**: If the range of input values is small, Counting Sort can be more efficient than comparison-based sorting algorithms like Quick Sort or Merge Sort.
2. **Stable Sorting**: Counting Sort is a stable sorting algorithm, meaning that the relative order of equal elements is preserved. This makes it useful when sorting data where the order of equal elements is important, such as sorting strings based on their characters.
3. **Integer Inputs**: Counting Sort is best suited for sorting integer inputs, as it relies on counting the occurrences of each element. It may not be as efficient for sorting non-integer data types.

## How it Works

1. Find the maximum element in the input array.
2. Initialize a count array of size (max + 1) with all elements as 0.
3. Store the count of each element of the input array in the count array.
4. Modify the count array by replacing each element with the sum of the previous elements.
5. Create a new array with the same size as the input array.
6. Iterate through the input array and place the element at the index calculated from the count array.
7. Decrease the count of the element by 1 for each placement.

The algorithm gets its name from the fact that it counts the number of occurrences of each element in the input array.

## Code Example

Here's an example implementation of the Counting Sort algorithm in C#:

```csharp

public static void Sort(int[] array)
{
    Utils.Utils.PrintArrayHeader(algorithmName: " Counting Sort Algorithm");
    Utils.Utils.PrintArray(array: array, arrayDescription: "Array to sort:");


    int[] counts = new int[array.Max() + 1];

    foreach (var item in array)
    {
        counts[item]++;
    }

    var k = 0;
    for (int i = 0; i < counts.Length; i++)
    {
        for (int j = 0; j < counts[i]; j++)
        {
            array[k++] = i;
        }
    }

    Utils.Utils.PrintArray(array: array, arrayDescription: "Sorted array");
    Utils.Utils.PrintArrayFooter();

}
```

The `CountingSort` method takes an integer array `arr` and modifies it in-place to sort the array in ascending order.

## Usage Example

Here's an example of how to use the `CountingSort` method:

```csharp
int[] numbers = { 5, 2, 8, 1, 9 };
CountingSort(numbers);

// The numbers array is now sorted: { 1, 2, 5, 8, 9 }
```

You can call the `CountingSort` method with any integer array, and it will sort the array in ascending order.

## Time Complexity

The time complexity of Counting Sort is shown in the following table:

| Metric     | Best Case | Worst Case |
|------------|-----------|------------|
| Populate counts | O(n)     | O(n)       |
| Iterate counts | O(k)     | O(k)       |
| Total      | O(n + k)  | O(n + k)   |
| Space      | O(k)      | O(k)       |

The best-case and worst-case time complexities are the same, as the algorithm performs the same operations regardless of the input.

The space complexity is O(k), where k is the range of the input values. This is because the algorithm uses an additional array of size (max + 1) to store the count of each element.

Counting Sort is most effective when the range of input values (k) is not significantly greater than the number of elements (n). If the range is much larger, the space complexity becomes the limiting factor, and other comparison-based sorting algorithms, such as Quick Sort or Merge Sort, might be more efficient.

However, Counting Sort has the advantage of being a stable sorting algorithm, meaning that the relative order of equal elements is preserved. This makes it useful in certain scenarios, such as when sorting strings based on their characters.
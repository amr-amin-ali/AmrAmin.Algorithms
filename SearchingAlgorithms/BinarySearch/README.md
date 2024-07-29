# Binary Search Algorithm

The binary search algorithm is an efficient way to search for a target value within a sorted array or list. It works by repeatedly dividing the search space in half until the target value is found or it is determined that the target value is not present in the data structure.

## Algorithm Description

The binary search algorithm works as follows:

1. Initialize the lower and upper bounds of the search range to the first and last indices of the sorted array, respectively.
2. Repeatedly:
   - Calculate the midpoint of the current search range.
   - Compare the value at the midpoint to the target value.
   - If the value at the midpoint is equal to the target value, return the midpoint index.
   - If the value at the midpoint is less than the target value, update the lower bound to the midpoint + 1.
   - If the value at the midpoint is greater than the target value, update the upper bound to the midpoint - 1.
3. If the target value is not found after the search range has been exhausted, return a value indicating that the element was not found.

## Recursive Implementation

Here's an example implementation of the binary search algorithm in C# using recursion:

```csharp
public static int BinarySearchRecursive<T>(T[] arr, T target) where T : IComparable<T>
{
    return BinarySearchRecursive(arr, target, 0, arr.Length - 1);
}

private static int BinarySearchRecursive<T>(T[] arr, T target, int left, int right) where T : IComparable<T>
{
    if (left > right)
        return -1; // Target not found

    int mid = left + (right - left) / 2;

    if (arr[mid].CompareTo(target) == 0)
        return mid; // Target found
    else if (arr[mid].CompareTo(target) < 0)
        return BinarySearchRecursive(arr, target, mid + 1, right); // Target is in the right half
    else
        return BinarySearchRecursive(arr, target, left, mid - 1); // Target is in the left half
}
```

This implementation uses a helper method `BinarySearchRecursive` that takes the array, the target value, and the current search range (left and right indices). The method recursively narrows the search range until the target is found or the search range is exhausted.

## Iterative Implementation

Here's an example implementation of the binary search algorithm in C# using an iterative approach:

```csharp
public static int BinarySearchIterative<T>(T[] arr, T target) where T : IComparable<T>
{
    int left = 0;
    int right = arr.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (arr[mid].CompareTo(target) == 0)
            return mid; // Target found
        else if (arr[mid].CompareTo(target) < 0)
            left = mid + 1; // Target is in the right half
        else
            right = mid - 1; // Target is in the left half
    }

    return -1; // Target not found
}
```

This implementation uses a while loop to repeatedly narrow the search range until the target is found or the search range is exhausted.

## Constraints

The binary search algorithm has the following constraints:

1. **Sorted Array/List**: The array or list must be sorted in either ascending or descending order for the binary search to work correctly.
2. **Comparable Elements**: The elements in the array or list must implement the `IComparable<T>` interface, which allows them to be compared with each other.
3. **Unique Target**: If the target value appears multiple times in the array or list, the binary search algorithm will return the index of the first occurrence of the target value.

## Usage Example

Here's an example of how to use the binary search algorithm:

```csharp
int[] numbers = { 3, 5, 6, 9, 11, 18, 20, 21, 24, 30 };
int targetValue = 11;

int index = BinarySearchRecursive(numbers, targetValue);
if (index == -1)
{
    Console.WriteLine($"The value {targetValue} was not found in the array.");
}
else
{
    Console.WriteLine($"The value {targetValue} was found at index {index}.");
}
```

In this example, we create a sorted array of integers and search for the value `11` using the `BinarySearchRecursive` method. If the value is found, we print the index where it was found. If the value is not found, we print a message indicating that the value was not found.

The time complexity of the binary search algorithm is O(log n), where n is the size of the input array or list. This is because, in each iteration, the search space is halved, which means the number of comparisons required to find the target value (or determine that it is not present) grows logarithmically with the size of the input.
# Linear Search Algorithm

Linear search, also known as sequential search, is a basic algorithm for finding a target value within a list or array. It works by iterating through the elements of the list one by one, starting from the first element, until the target value is found or the end of the list is reached.

## Algorithm Description

The linear search algorithm works as follows:

1. Start at the first element of the list or array.
2. Compare the current element with the target value.
3. If the current element is equal to the target value, return the index of the current element.
4. If the current element is not equal to the target value, move to the next element in the list or array.
5. Repeat steps 2-4 until the target value is found or the end of the list or array is reached.
6. If the target value is not found, return a value indicating that the element was not found.

## C# Code Example

Here's an example implementation of the linear search algorithm in C#:

```csharp

public static class LinearSearch
{
    public static int Search(int[] arr, int target)
    {
        SearchingUtils.PrintSearchHeader(" Linear Search");
        SearchingUtils.PrintArray(arr, "Array to search in:");
        SearchingUtils.PrintTarget(target);
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Equals(target))
            {
                SearchingUtils.PrintResult(i);
                SearchingUtils.PrintArrayFooter();
                return i;
            }
        }
        SearchingUtils.PrintResult(-1);
        SearchingUtils.PrintArrayFooter();
        return -1;
    }
}

```

This method takes an array of type `T` and a target value of type `T`, and returns the index of the target value in the array, or `-1` if the target value is not found.

The `where T : IEquatable<T>` constraint ensures that the type `T` implements the `IEquatable<T>` interface, which allows us to compare the elements of the array with the target value using the `Equals` method.

## Usage Example

Here's an example of how to use the `LinearSearch` method:

```csharp
int[] numbers = { 5, 2, 8, 12, 1 };
int targetValue = 8;
int index = LinearSearch(numbers, targetValue);
if (index == -1)
{
    Console.WriteLine($"The value {targetValue} was not found in the array.");
}
else
{
    Console.WriteLine($"The value {targetValue} was found at index {index}.");
}
```

In this example, we create an array of integers and search for the value `8` using the `LinearSearch` method. If the value is found, we print the index where it was found. If the value is not found, we print a message indicating that the value was not found.

The time complexity of the linear search algorithm is O(n), where n is the size of the input array or list. This is because, in the worst case, the algorithm needs to check every element in the list before determining that the target value is not present.
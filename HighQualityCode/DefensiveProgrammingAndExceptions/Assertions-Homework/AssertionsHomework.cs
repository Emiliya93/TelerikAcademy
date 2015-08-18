using System;
using System.Diagnostics;
using System.Linq;

public class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array cannot be null.");
        Debug.Assert(arr.Length > 0, "Array cannot be empty.");

        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        Debug.Assert(CheckIfArrayIsSorted(arr), "Selection sort did not sort elements.");
    }

    private static bool CheckIfArrayIsSorted<T>(T[] arr) where T : IComparable<T>
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i].CompareTo(arr[i + 1]) > 0)
            {
                return false;
            }
        }

        return true;
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(startIndex >= 0, "Start index must be greater than or equal to 0.");
        Debug.Assert(endIndex >= 0, "End index must be greater than or equal to 0.");
        Debug.Assert(startIndex <= endIndex, "Start index must be less than or equal to end index.");

        int minElementIndex = startIndex;

        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        Debug.Assert(CheckIfMinElementIndexIsValid(arr, startIndex, endIndex, minElementIndex), "Min element index is not correct!");

        return minElementIndex;
    }

    private static bool CheckIfMinElementIndexIsValid<T>(T[] arr, int startIndex, int endIndex, int minElementIndex)
        where T : IComparable<T>
    {
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (arr[minElementIndex].CompareTo(arr[i]) > 0)
            {
                return false;
            }
        }

        return true;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Array cannot be null.");
        Debug.Assert(arr.Length > 0, "Array cannot be empty.");

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(startIndex >= 0, "Start index must be greater than or equal to 0.");
        Debug.Assert(endIndex >= 0, "End index must be greater than or equal to 0.");
        Debug.Assert(startIndex <= endIndex, "Start index must be less than or equal to end index.");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        //SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));

        Console.WriteLine(BinarySearch(new int[]{1000}, 1000));
    }
}

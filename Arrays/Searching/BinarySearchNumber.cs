namespace Searching;

public class BinarySearchNumber
{
    public int BinarySearch(int[] arr, int target) // поиск числа в отсортированном массиве
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target) return mid;

            if (arr[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }

    public int BinarySearch2(int[] arr, int target) // поиск числа в отсортированном массиве
    {
        int left = -1, right = arr.Length;
        while (right - left > 1)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target) return mid;

            if (arr[mid] > target)
            {
                right = mid;
            }
            else
            {
                left = mid;
            }
        }

        return -1;
    }
}

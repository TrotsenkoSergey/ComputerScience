namespace Searching;

public class BinarySearchCondition
{
    // когда сначала плохо, потом хорошо. Мы ищем старт границы между плохим и хорошим. Первое подходящее значение.
    public int LeftBinarySearch<T>(int left, int right, Func<int, T, bool> condition, T parameters) 
    {
        while (left < right) 
        {
            int mid = left + (right - left) / 2; // == (left + right) / 2

            if (condition(mid, parameters))
            {
                right = mid;
            }
            else
            { 
                left = mid + 1;
            }
        }

        return left;
    }

    // когда сначала хорошо, потом хорошо. Мы ищем первое вхождение - 1 когда стало плохо. Последнее подходящее значение.
    public int RightBinarySearch<T>(int left, int right, Func<int, T, bool> condition, T parameters)
    {
        
        while (left < right)
        {
            int mid = (left + right + 1) / 2;  // (int)(left + (right - left) / 2f + 1 / 2f); //Math.Round((left + right) / 2f)

            if (condition(mid, parameters))
            {
                left = mid;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left;
    }
}

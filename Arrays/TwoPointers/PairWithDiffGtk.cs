namespace TwoPointers;

/* 
Дан не убывающий массив целых чисел и целое число k. 
Определить, количество пар для которых их разность больше чем k (A - B > K).
 
 r
[1, 3, 3, 4, 5, 6], k = 2
 l

count = 5

 */

public class PairWithDiffGtk
{
    // Time: O(n), Space: O(1)
    public int CalculatePairWithDiffGtk(int[] nums, int target) // A-B>K
    {
        int right = 0;
        int count = 0;

        for (int left = 0; left < nums.Length; left++) 
        {
            while (right < nums.Length && nums[right] - nums[left] <= target) 
            {
                right++;
            }
            count += nums.Length - right;
        }

        return count;
    }
}

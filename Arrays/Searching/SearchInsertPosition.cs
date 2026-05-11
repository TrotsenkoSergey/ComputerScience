namespace Searching;

/* 35. Search Insert Position
 
Given a sorted array of distinct integers and a target value, 
return the index if the target is found. 
If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

Example 1:
Input: nums = [1,3,5,6], target = 5
Output: 2

Example 2:
Input: nums = [1,3,5,6], target = 2
Output: 1

Example 3:
Input: nums = [1,3,5,6], target = 7
Output: 4

Constraints:
1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums contains distinct values sorted in ascending order.
-104 <= target <= 104
 */

// Time: O(log(n))
public class SearchInsertPosition
{
    public int SearchInsert(int[] nums, int target)
    {
        
        int left = 0;
        int right = nums.Length - 1;

        while (left < right) 
        {
            int mid = left + (right - left) / 2;

            if (Check(nums, mid, target))
            {
                right = mid;
            }
            else 
            {
                left = mid + 1;
            }
        }

        if (!Check(nums, left, target)) // corner case when target > then all elements
        { 
            left++;
        }

        return left;
    }

    // [1,3,5,6], target = 7
    private bool Check(int[] nums, int index, int target) 
    { 
        return nums[index] >= target;
    }   
}

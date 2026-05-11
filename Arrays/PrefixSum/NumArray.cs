namespace PrefixSum;

/* 303. Range Sum Query - Immutable https://leetcode.com/problems/range-sum-query-immutable/description/
 Given an integer array nums, handle multiple queries of the following type:

Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
Implement the NumArray class:

NumArray(int[] nums) Initializes the object with the integer array nums.
int sumRange(int left, int right) Returns the sum of the elements of nums between indices left and right inclusive (i.e. nums[left] + nums[left + 1] + ... + nums[right]).
 

Example 1:

Input
["NumArray", "sumRange", "sumRange", "sumRange"]
[[[-2, 0, 3, -5, 2, -1]], [0, 2], [2, 5], [0, 5]]
Output
[null, 1, -1, -3]

Explanation
NumArray numArray = new NumArray([-2, 0, 3, -5, 2, -1]);
numArray.sumRange(0, 2); // return (-2) + 0 + 3 = 1
numArray.sumRange(2, 5); // return 3 + (-5) + 2 + (-1) = -1
numArray.sumRange(0, 5); // return (-2) + 0 + 3 + (-5) + 2 + (-1) = -3
 

Constraints:
1 <= nums.length <= 104
-105 <= nums[i] <= 105
0 <= left <= right < nums.length
At most 104 calls will be made to sumRange.
 */

// Time: O(n + m), Space: O(n)
public class NumArray
{
    private readonly int[] _prefixSums;
    public NumArray(int[] nums)
    {
        _prefixSums = BuildPrefixSum(nums);
    }

    // Time: O(m), Space: O(1), where m - calls to SumRange
    public int SumRange(int left, int right)
    {
        return _prefixSums[right + 1] - _prefixSums[left];
    }

    // Time: O(n), Space: O(n), where n - nums.Length
    private int[] BuildPrefixSum(int[] nums)
    {
        int[] prefixSums = new int[nums.Length + 1];
        prefixSums[0] = 0;

        for (int i = 1; i < prefixSums.Length; i++)
        {
            prefixSums[i] = nums[i - 1] + prefixSums[i - 1];
        }
        return prefixSums;
    }
}

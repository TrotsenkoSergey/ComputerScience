namespace SlidingWindow;

// naive solution - O(k * (n - k)), worst case ~ O(n^2)
// Time: O(n), Space: O(1)
public class MaximumAverageSubarrayI
{
    /*
     643. Maximum Average Subarray I
    
    You are given an integer array nums consisting of n elements, and an integer k.
    Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. 
    Any answer with a calculation error less than 10^-5 will be accepted.

    Example 1:
    Input: nums = [1,12,-5,-6,50,3], k = 4
    Output: 12.75000
    Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75

    Example 2:
    Input: nums = [5], k = 1
    Output: 5.00000

    Constraints:
    n == nums.length
    1 <= k <= n <= 10^5
    -10^4<= nums[i] <= 10^4
    */

    public double FindMaxAverage(int[] nums, int k)
    {
        int n = nums.Length;
        if (n == 1) return nums[0];

        int sum = 0;
        for (int i = 0; i < k; i++) // k
        {
            sum += nums[i];
        }
        int maxSum = sum;

        int left = 0;
        int right = k - 1;
        for (left++, right++; right < n; left++, right++) // n
        {
            sum -= nums[left - 1];
            sum += nums[right];
            maxSum = int.Max(maxSum, sum);
        }

        return maxSum / (double)k;
    }
}

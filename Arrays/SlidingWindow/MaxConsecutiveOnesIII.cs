namespace SlidingWindow;

public class MaxConsecutiveOnesIII
{
    /* 1004. Max Consecutive Ones III https://leetcode.com/problems/max-consecutive-ones-iii/description/
     
    Given a binary array nums and an integer k, 
    return the maximum number of consecutive 1's in the array if you can flip at most k 0's.

    Example 1:
    Input: nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
    Output: 6
    Explanation:  [1,1,1,0,0,1,1,1,1,1,1]
    Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.

    Example 2:
    Input: nums = [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1], k = 3
    Output: 10
    Explanation:  [0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1]
    Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.

    Constraints:
    1 <= nums.length <= 105 ==> 128 bit -> 4 * int32
    nums[i] is either 0 or 1.
    0 <= k <= nums.length
     */


    //               r   
    // 0 1 1 0 0 1 1 1
    //   l
    // 
    // zeros = 2, k = 2
    // max = 7

    // O(n) time and O(1) space
    public int LongestOnes(int[] nums, int k)
    {
        int max = 0;
        int zeroCounter = 0;
        int left = 0;

        for (int right = 0; right < nums.Length; right++) 
        {
            if (nums[right] == 0)
                zeroCounter++;

            while (zeroCounter > k) 
            {
                if (nums[left] == 0) 
                    zeroCounter--;

                left++;
            }

            int currentMax = right - left + 1;
            if (currentMax > max)
                max = currentMax;
        }

        return max;
    }

    //public int LongestOnes(int[] nums, int k)
    //{
    //    int longestOnes = 0;
    //    int index = 0;
    //    while (index < nums.Length) 
    //    {
    //        (int max, index) = HandleSlidingWindow(nums, k, index);
    //        if(max > longestOnes)
    //            longestOnes = max;
    //    }

    //    return longestOnes;
    //}

    //private (int Max, int Index) HandleSlidingWindow(int[] nums, int k, int i)
    //{
    //    var sw = CreateWindow();
    //    sw.Left = i;
    //    sw.Right = i;
    //    sw.OneCount = 0;
    //    sw.ZeroCount = 0;

    //    int max = 0;
    //    for (; i < nums.Length; i++)
    //    {
    //        if (nums[i] == 1)
    //        {
    //            sw.OneCount++;
    //            sw.Right++;
    //        }
    //        else if (sw.ZeroCount < k)
    //        {
    //            sw.OneCount++;
    //            sw.Right++;
    //            sw.ZeroCount++;
    //            sw.Zeros.Add(i);
    //        }
    //        else if (sw.Left < sw.Right)
    //        {
    //            if (sw.Zeros.Contains(sw.Left))
    //                sw.OneCount++;

    //            int currentMax = sw.Right - sw.Left;
    //            if (currentMax > max)
    //                max = currentMax;

    //            sw.Left++;
    //        }
    //        else
    //        {
    //            break;
    //        }
    //    }

    //    return (max, i);
    //}

    //SlidingWindow CreateWindow() => new();

    //// disposed when k == ZeroCount && Left == Right
    //class SlidingWindow
    //{
    //    public int Left { get; set; }
    //    public int Right { get; set; }
    //    public int OneCount { get; set; }
    //    public int ZeroCount { get; set; }
    //    public List<int> Zeros { get; set; } = [];
    //}
}

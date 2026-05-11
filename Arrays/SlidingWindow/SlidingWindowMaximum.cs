namespace SlidingWindow;

public class SlidingWindowMaximum
{
    /* 239. Sliding Window Maximum https://leetcode.com/problems/sliding-window-maximum/
     
    You are given an array of integers nums, 
    there is a sliding window of size k which is moving from the very left of the array to the very right. 
    You can only see the k numbers in the window. 
    Each time the sliding window moves right by one position.
    Return the max sliding window.
    
    Example 1:
    Input: nums = [1,3,-1,-3,5,3,6,7], k = 3
    Output: [3,3,5,5,6,7]
    
    Explanation: 
    Window position                Max
    ---------------               -----
    [1  3  -1] -3  5  3  6  7       3
     1 [3  -1  -3] 5  3  6  7       3
     1  3 [-1  -3  5] 3  6  7       5
     1  3  -1 [-3  5  3] 6  7       5
     1  3  -1  -3 [5  3  6] 7       6
     1  3  -1  -3  5 [3  6  7]      7
    
    Example 2:
    Input: nums = [1], k = 1
    Output: [1]
    
    Constraints:
    1 <= nums.length <= 105
    -104 <= nums[i] <= 104
    1 <= k <= nums.length

     */
    
    // naive solution - O(k * (n - k))
    
    // Time: O(n), Space: O(n)
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int[] output = new int[nums.Length - k + 1];

        LinkedList<int> deqve = new(); // contains indexes of nums

        int left = 0;
        int right = 0;
        while (right < nums.Length) 
        {
            while (deqve.Count != 0 && nums[deqve.Last.Value] < nums[right]) 
            {
                deqve.RemoveLast(); // O(1)
            }
            deqve.AddLast(right); // O(1)

            if (left > deqve.First.Value) 
            {
                deqve.RemoveFirst(); // O(1)
            }

            if ((right + 1) >= k) 
            {
                output[left] = nums[deqve.First.Value];
                left++;
            }

            right++;
        }

        return output;
    }
}

namespace Intervals;

/* 57. Insert Interval https://leetcode.com/problems/insert-interval/description/
 
You are given an array of non-overlapping intervals intervals 
where intervals[i] = [starti, endi] represent the start and the end of the ith interval 
and intervals is sorted in ascending order by starti. 
You are also given an interval newInterval = [start, end] that represents the start and end of another interval.

Insert newInterval into intervals such that intervals is still sorted in ascending order by starti 
and intervals still does not have any overlapping intervals 
(merge overlapping intervals if necessary).

Return intervals after the insertion.

Note that you don't need to modify intervals in-place. You can make a new array and return it.

Example 1:
Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
Output: [[1,5],[6,9]]

Example 2:
Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
Explanation: Because the new interval [4,8] overlaps with [3,5],[6,7],[8,10].
 
 */

public class InsertInterval
{
    public int[][] Insert2(int[][] intervals, int[] newInterval)
    {
        int startNewInterval = newInterval[0];
        int endNewInterval = newInterval[1];

        List<int[]> result = [];
        int intervalsLength = intervals.Length;
        int i = 0;

        // add until meet new interval                        // end intervals
        int firstStartOverlapping = BinarySearch(intervals, newInterval[0]); 
        result.AddRange(intervals[..firstStartOverlapping]);

        // merge                                            // start intervals
        while (i < intervalsLength && endNewInterval >= intervals[i][0])
        {
            startNewInterval = Math.Min(startNewInterval, intervals[i][0]);
            endNewInterval = Math.Max(endNewInterval, intervals[i][1]);
            i++;
        }

        // add new interval
        result.Add([startNewInterval, endNewInterval]);

        // add last
        while (i < intervalsLength)
        {
            result.Add(intervals[i]);
            i++;
        }

        return [.. result];
    }

    private int BinarySearch(int[][] intervals, int target)
    {
        int left = 0;
        int right = intervals.Length - 1;
        while (left < right)
        {
            int mid = (left + right + 1) / 2;
            if (intervals[mid][0] <= target)
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


    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        int startNewInterval = newInterval[0];
        int endNewInterval = newInterval[1];

        List<int[]> result = [];
        int intervalsLength = intervals.Length;
        int i = 0;

        // add until meet new interval                        // end intervals
        while (i < intervalsLength && startNewInterval > intervals[i][1])
        { 
            result.Add(intervals[i]); 
            i++;
        }

        // merge                                            // start intervals
        while (i < intervalsLength && endNewInterval >= intervals[i][0])
        {
            startNewInterval = Math.Min(startNewInterval, intervals[i][0]);
            endNewInterval = Math.Max(endNewInterval, intervals[i][1]);
            i++;
        }

        // add new interval
        result.Add([startNewInterval, endNewInterval]);

        // add last
        while (i < intervalsLength)
        { 
            result.Add(intervals[i]);
            i++;
        }

        return [..result];
    }
}

namespace Sorting;

/* 435. Non-overlapping Intervals
Given an array of intervals intervals where intervals[i] = [starti, endi], 
return the minimum number of intervals you need to remove to make the rest of the intervals non-overlapping.

Note that intervals which only touch at a point are non-overlapping. 
For example, [1, 2] and [2, 3] are non-overlapping.
 

Example 1:
Input: intervals = [[1,2],[2,3],[3,4],[1,3]]
Output: 1
Explanation: [1,3] can be removed and the rest of the intervals are non-overlapping.

Example 2:
Input: intervals = [[1,2],[1,2],[1,2]]
Output: 2
Explanation: You need to remove two [1,2] to make the rest of the intervals non-overlapping.

Example 3:
Input: intervals = [[1,2],[2,3]]
Output: 0
Explanation: You don't need to remove any of the intervals since they're already non-overlapping.

Constraints:
1 <= intervals.length <= 105
intervals[i].length == 2
-5 * 104 <= starti < endi <= 5 * 104

 */
public class NoOverlapingIntervals
{
    public int EraseOverlapIntervalsWRONG(int[][] intervals) // WRONG!!!!
    {
        IEnumerable<int> inRange = intervals.Select(x => x[0]);
        IEnumerable<int> outRange = intervals.Select(x => x[1]);

        List<TimeState> ordered =
            inRange.Select(x => new TimeState(x, State.Start))
                   .Concat(outRange.Select(x => new TimeState(x, State.End))) // merge 2 arr
                   .OrderBy(x => x.Value)
                   .ThenByDescending(x => x.State)
                   .ToList(); // Time: O(n*log(n)), Space: O(n)

        int overlap = 0;
        int count = 0;
        foreach (TimeState el in ordered)
        {
            if (el.State == State.Start)
            {
                count++;
                if (count > 1) overlap++;
            }
            else // el.State == State.End
            {
                if (count > 1) count--;
            }
        }

        return overlap;
    }

    record TimeState(int Value, State State);
    enum State { Start, End }

    static int Compare(int[] l, int[] r)
    {
        if (l[0] > r[0]) return 1;
        else if (l[0] < r[0]) return -1;
        else return 0;
    }

    // Time: O(n*log(n)), Space: O(n)
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, Compare);
        var orderedIntervals = intervals;
        //var orderedIntervals = intervals.OrderBy(x => x[0]).ToArray();

        int previous = orderedIntervals[0][1];
        int overlaping = 0;
        for (int i = 1; i < orderedIntervals.Length; i++)
        {
            int start = orderedIntervals[i][0];
            int end = orderedIntervals[i][1];

            if (start >= previous)
                previous = end;
            else
            {
                overlaping++;
                if (end < previous)
                    previous = end;
            }
        }

        return overlaping;
    }
}

namespace Stacks;

/* 739. Daily Temperatures https://leetcode.com/problems/daily-temperatures/description/
 
Given an array of integers temperatures represents the daily temperatures, 
return an array answer such that answer[i] is the number of days 
you have to wait after the ith day to get a warmer temperature. 
If there is no future day for which this is possible, keep answer[i] == 0 instead.

Example 1:
Input: temperatures = [73,74,75,71,69,72,76,73]
Output: [1,1,4,2,1,1,0,0]

Example 2:
Input: temperatures = [30,40,50,60]
Output: [1,1,1,0]

Example 3:
Input: temperatures = [30,60,90]
Output: [1,1,0]

Constraints:
1 <= temperatures.length <= 105
30 <= temperatures[i] <= 100
 
 */

public class MonotonicStack
{
    /*
            i     
input =  [ 73, 74, 75, 71, 69, 72, 76, 73 ]
            0   1   2   3   4   5   6   7
result = [  1   1   4   2   1   1   0   0 ]
                                                        stack = [ (73,0)
                                                                  (74,1)
                                                                  (75,2)
                                                                  (76,6)  
                                                                        ]

expected = [1,1,4,2,1,1,0,0]
    
     */

    // Time: O(n + k), Space(k + n)
    public int[] DailyTemperatures(int[] temperatures)
    {
        Stack<(int Value, int Index)> stack = [];
        int[] results = new int[temperatures.Length];

        for (int i = temperatures.Length - 1; i >= 0; i--) 
        {
            int currentValue = temperatures[i];
            int result = 0;
            while (stack.Count != 0) 
            {
                var element = stack.Peek();
                if (currentValue >= element.Value)
                {
                    stack.Pop();
                }
                else // currentValue < element.Value
                {
                    result = element.Index - i;
                    break;
                }
            }

            stack.Push((currentValue, i));
            results[i] = result;
        }

        return results;
    }
}

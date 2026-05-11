namespace TypicalProblems;

/* Find Numbers with Even Number of Digits https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3237/
 Given an array nums of integers, return how many of them contain an even number of digits.
Example 1:

Input: nums = [12,345,2,6,7896]
Output: 2
Explanation: 
12 contains 2 digits (even number of digits). 
345 contains 3 digits (odd number of digits). 
2 contains 1 digit (odd number of digits). 
6 contains 1 digit (odd number of digits). 
7896 contains 4 digits (even number of digits). 
Therefore only 12 and 7896 contain an even number of digits.
Example 2:

Input: nums = [555,901,482,1771]
Output: 1 
Explanation: 
Only 1771 contains an even number of digits.
 

Constraints:

1 <= nums.length <= 500
1 <= nums[i] <= 105
 */

// Time: O(n * log(m)), Space: O(1)
public class FindNumbersWithEvenNumberOfDigits
{
    public int FindNumbers(int[] nums)
    {
        int evenDigitCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;
            int number = nums[i];
            while (number > 0)
            {
                number /= 10;
                count++;
            }

            if (count % 2 == 0)
            {
                evenDigitCount++;
            }
        }
        return evenDigitCount;
    }

    // Time: O(n), Space: O(1)
    public int FindNumbers2(int[] nums)
    {
        /*
        Let's take a look at the constraint again.
        
        1 ≤ nums[i] ≤ 10^5
         
        OR
        
        1 ≤ nums[i] ≤ 100000
        
        Let's take a look at the integers in the range [1,100000].
        
        1⇝9 have 1, hence an odd number of digits.
        10⇝99 have 2, hence an even number of digits.
        100⇝999 have 3, hence an odd number of digits.
        1000⇝9999 have 4, hence an even number of digits.
        10000⇝99999 have 5, hence an odd number of digits.
        100000 has 6, hence an even number of digits.
        */
        int evenDigitCount = 0;

        foreach (int num in nums)
        {
            if (num >= 10 && num <= 99 || num >= 1000 && num <= 9999 || num == 100000)
                evenDigitCount++;
        }

        return evenDigitCount;
    }
}

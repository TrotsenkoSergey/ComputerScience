namespace TypicalProblems;

/* 371. Sum of Two Integers https://leetcode.com/problems/sum-of-two-integers/description/

Given two integers a and b, return the sum of the two integers without using the operators + and -.

Example 1:
Input: a = 1, b = 2
Output: 3

Example 2:
Input: a = 2, b = 3
Output: 5

Constraints:
-1000 <= a, b <= 1000

 */

public class SumOfTwoIntegers
{
    public int GetSum(int a, int b)
    {
        int carry = 0;
        int sum = 0;

        bool aIsNegative = int.IsNegative(a);

        // solution fro non negative numbers
        for (int i = 0; i < 10; i++) // 10 -> 2^10 -> 1024
        {
            int aBit = (a >> i) & 1;
            int bBit = (b >> i) & 1;
            int sumBit = carry ^ aBit ^ bBit;

            sum |= sumBit << i;
            carry = (aBit & bBit) | ((aBit ^ bBit) & (carry & 1));
        }

        return sum;
    }


    public int GetSum2(int a, int b)
    {
        int c;
        while (b != 0)
        {
            c = a & b;
            a = a ^ b;
            b = c << 1;
        }
        return a;

    }

    public int GetSum3(int a, int b)
    {
        while (b != 0)
        {
            int temp = a & b;
            a = a ^ b;
            b = temp << 1;
        }

        return a;
    }
}

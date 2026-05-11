namespace TwoPointers;

public class LongestPalindromicSubstring
{
    /*5. Longest Palindromic Substring https://leetcode.com/problems/longest-palindromic-substring/description/
     
    Given a string s, return the longest palindromic substring in s.

    Example 1:
    Input: s = "babad"
    Output: "bab"
    Explanation: "aba" is also a valid answer.
    
    Example 2:
    Input: s = "cbbd"
    Output: "bb"

    Constraints:

    1 <= s.length <= 1000
    s consist of only digits and English letters.
     */

    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return "";
        }

        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            string leftPalindrom = GetPalindromeWithMirror(s, i, i);
            if (leftPalindrom.Length > res.Length)
                res = leftPalindrom;

            string rightPalindrom = GetPalindromeWithMirror(s, i, i + 1); // corner case "bb" - старт с двух букв 
            if (rightPalindrom.Length > res.Length)
                res = rightPalindrom;
        }

        return res;
    }

    private string GetPalindromeWithMirror(string s, int start, int end) // start == end or start == end - 1
    {
        while (start >= 0 && end < s.Length && s[start] == s[end])
        {
            start--;
            end++;
        }

        return s[(start + 1)..end];
    }
}

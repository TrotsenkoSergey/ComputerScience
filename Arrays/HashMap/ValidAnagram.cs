namespace HashMap;

/* 242. Valid Anagram https://leetcode.com/problems/valid-anagram/description/

Given two strings s and t, return true if t is an anagram of s, and false otherwise.
 

Example 1:
Input: s = "anagram", t = "nagaram"
Output: true

Example 2:
Input: s = "rat", t = "car"
Output: false
 

Constraints:
1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.

*/

// Time: O(n), Space: O(n)
internal class ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> set = [];
        foreach (char ch in s)
        {
            if (set.ContainsKey(ch))
                set[ch] += 1;
            else set.Add(ch, 1);
        }

        foreach (char ch in t)
        {
            if (set.ContainsKey(ch) && set[ch] != 0)
                set[ch] -= 1;
            else return false;
        }

        return true;
    }
}

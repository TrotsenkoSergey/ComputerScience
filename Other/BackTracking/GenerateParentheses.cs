namespace BackTracking;

/* 22. Generate Parentheses https://leetcode.com/problems/generate-parentheses/description/
 
 Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

Example 1:
Input: n = 3
Output: ["((()))","(()())","(())()","()(())","()()()"]

Example 2:
Input: n = 1
Output: ["()"]

Constraints:
1 <= n <= 8
 
 */

public class GenerateParentheses
{
    public IList<string> GenerateParenthesis(int n)
    {
        Generate(n, 1, 0, "(");
        return combinations;
    }

    List<string> combinations = [];
    private void Generate(int n, int open, int closed, string current)
    {
        if (open == closed && open == n)
        {
            combinations.Add(current);
            return;
        }

        if (open < n) // can add open
        {
            Generate(n, open + 1, closed, current + '(');
        }

        if (closed < open && closed < n) // can add closed
        {
            Generate(n, open, closed + 1, current + ')');
        }
    }
}

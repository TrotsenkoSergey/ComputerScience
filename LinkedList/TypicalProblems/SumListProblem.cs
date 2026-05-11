namespace TypicalProblems;

public class SumListProblem
{
    // Time: O(n), Space O(1)
    // Recursive: Space O(n) - call stack
    public int Sum(LinkedList<int>? node)
    {
        if (node is null) return -1;

        int sum = 0;
        LinkedList<int>? current = node;
        while (current is not null)
        {
            sum += current.Value;
            current = current.Next;
        }

        return sum;
    }
}

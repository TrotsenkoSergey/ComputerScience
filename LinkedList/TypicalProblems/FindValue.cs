namespace TypicalProblems;

public class FindValue
{
    // Time: O(n), Space O(1)
    public LinkedList<int>? Find(LinkedList<int>? node, int target)
    {
        if (node is null) return null;

        var current = node;
        while (current is not null)
        {
            if (current.Value == target) return current;
            current = current.Next;
        }

        return null;
    }
}

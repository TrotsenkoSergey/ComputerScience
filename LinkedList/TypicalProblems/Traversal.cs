namespace TypicalProblems;

public class Traversal
{
    // Time: O(n), Space: O(n)
    public int[] Traverse(LinkedList<int> node) 
    {
        if (node is null)
            return [];

        LinkedList<int>? current = node;

        List<int> arr = [];
        while (current is not null) 
        {
            arr.Add(current.Value);
            current = current.Next;
        }

        return [..arr];
    }

    // Time: O(n), Space: O(n) - call stack
    public List<int> TraverseRecursive(LinkedList<int>? node) 
    {
        if (node is null)
            return [];

        // pre-order - continuous
        List<int> result = TraverseRecursive(node.Next);
        // post-order - inverse
        result.Add(node.Value);

        return result;
    }
}

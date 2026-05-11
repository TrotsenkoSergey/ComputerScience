namespace TypicalProblems;

public class ReverseLinkedList
{
    // Time: O(n), Space: O(1)
    public LinkedList<int>? Reverse(LinkedList<int>? node)
    {
        LinkedList<int>? current = node;
        LinkedList<int>? previous = null;

        while (current is not null)
        {
            var next = current.Next;
            current.Next = previous; // null
            previous = current;  // a
            current = next; // b
        }

        return previous;
    }

    // Time: O(n), Space: O(n) - call stack
    public LinkedList<int>? ReverseRecursive(LinkedList<int>? node, LinkedList<int>? previous = null)
    {
        if (node is null) return previous;
        var result = ReverseRecursive(node.Next, node);
        node.Next = previous;
        return result;
    }
}

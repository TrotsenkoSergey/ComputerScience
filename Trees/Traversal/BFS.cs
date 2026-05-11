using Trees;

namespace Traversal;

public class BFS
{
    public void Traverse(BinaryTreeNode<string>? root)
    {
        var result = WithQueue(root);
        result.ForEach(Console.Write);

        Console.WriteLine();
    }

    // Time: O(n), Space: O(n)
    private List<string> WithQueue(BinaryTreeNode<string>? root)
    {
        if (root is null) return [];

        var result = new List<string>();
        Queue<BinaryTreeNode<string>> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node.Left is not null)
            {
                queue.Enqueue(node.Left);
            }

            if (node.Right is not null)
            {
                queue.Enqueue(node.Right);
            }

            result.Add(node.Value);
        }

        return result;
    }
}

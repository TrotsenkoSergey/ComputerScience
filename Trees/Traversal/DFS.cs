using Trees;

namespace Traversal;

public class DFS
{
    public void Traverse(BinaryTreeNode<string>? root) 
    {
        var result = WithStack(root);
        result.ForEach(Console.Write);

        Console.WriteLine();

        var result2 = WithRecursive(root);
        result2.ForEach(Console.Write);

        Console.WriteLine();
    }

    // Time: O(n), Space: O(n)
    private List<string> WithStack(BinaryTreeNode<string>? root) 
    {
        if (root is null) return [];

        List<string> res = [];
        Stack<BinaryTreeNode<string>> stack = new();
        stack.Push(root);

        while (stack.Count != 0)
        { 
            var node = stack.Pop();

            if (node.Right is not null)
            { 
                stack.Push(node.Right);
            }

            if (node.Left is not null)
            { 
                stack.Push(node.Left);
            }

            res.Add(node.Value);
        }
        return res;
    }

    // Time: O(n), Space: O(n)
    private List<string> WithRecursive(BinaryTreeNode<string>? root)
    {
        if (root is null) return [];

        List<string> left = WithRecursive(root.Left);
        List<string> right = WithRecursive(root.Right);

        return [root.Value, ..left, ..right];
    }
}

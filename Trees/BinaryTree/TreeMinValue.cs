using Trees;

namespace BinaryTree;

public class TreeMinValue
{
    public int? MinValue(BinaryTreeNode<int>? root) 
    {
        if (root is null) return null;
        int dfsRecursiveSolution = MinDFS(root);
        
        return dfsRecursiveSolution;
    }

    // Time: O(n), Space: O(n) - call stack 
    private int MinDFS(BinaryTreeNode<int>? root)
    {
        if (root is null) return int.MaxValue;

        int left = MinDFS(root.Left);
        int right = MinDFS(root.Right);

        int min = Math.Min(left, right);

        return Math.Min(root.Value, min);
    }

    // Time: O(n), Space: O(n)
    private int? MinDFSStack(BinaryTreeNode<int>? root)
    {
        if (root is null) return null;
        
        Stack<BinaryTreeNode<int>> stack = new();
        stack.Push(root);
        int smallestValue = int.MaxValue;

        while (stack.Count > 0)
        {
            var node = stack.Pop();
            smallestValue = Math.Min(smallestValue, node.Value);
            if (node.Right is not null)
            {
                stack.Push(node.Right);
            }
            if (node.Left is not null)
            {
                stack.Push(node.Left);
            }
        }

        return smallestValue;
    }

    // Time: O(n), Space: O(n)
    private int? MinBFS(BinaryTreeNode<int>? root)
    {
        if (root is null) return null;

        Queue<BinaryTreeNode<int>> queue = new();
        queue.Enqueue(root);
        int smallestValue = int.MaxValue;

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            smallestValue = Math.Min(smallestValue, node.Value);
            if (node.Right is not null)
            {
                queue.Enqueue(node.Right);
            }
            if (node.Left is not null)
            {
                queue.Enqueue(node.Left);
            }
        }

        return smallestValue;
    }
}

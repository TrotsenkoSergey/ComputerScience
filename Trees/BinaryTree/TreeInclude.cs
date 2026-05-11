using Trees;

namespace BinaryTree;

public class TreeInclude
{
    // Time: O(n), Space: O(n)
    public bool ExistBFS(BinaryTreeNode<int>? root, int target)
    {
        if (root is null) return false;
        Queue<BinaryTreeNode<int>> queue = new();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node.Value == target)
            {
                return true;
            }

            if (root.Left is not null)
            {
                queue.Enqueue(root.Left);
            }

            if (root.Right is not null)
            {
                queue.Enqueue(root.Right);
            }
        }

        return false;
    }

    // Time: O(n), Space: O(n)
    public bool ExistDFSStack(BinaryTreeNode<int>? root, int target)
    {
        if (root is null) return false;

        Stack<BinaryTreeNode<int>> stack = new();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var node = stack.Pop();
            if (node.Value == target)
            {
                return true;
            }
            if (node.Right is not null)
            {
                stack.Push(node.Right);
            }
            if (node.Left is not null)
            {
                stack.Push(node.Left);
            }
        }

        return false;
    }

    // Time: O(n), Space: O(n)
    public bool ExistDFSRecursive(BinaryTreeNode<int>? root, int target)
    {
        if (root is null) return false;

        if (root.Value == target) return true;
        return ExistDFSRecursive(root.Left, target) || ExistDFSRecursive(root.Right, target);
    }
}

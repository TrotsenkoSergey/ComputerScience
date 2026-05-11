using Trees;

namespace BinaryTree;

public class TreeSum
{
    // Time: O(n), Space: O(n) - call stack
    public int SumDFS(BinaryTreeNode<int>? root) // DFS with Recursion, post order traversal
    {
        if (root is null) return 0;

        int left = SumDFS(root.Left);
        int right = SumDFS(root.Right);

        int sum = left + right + root.Value;
        return sum;
    }

    // Time: O(n), Space: O(n) - call stack
    public int SumBFS(BinaryTreeNode<int>? root)
    {
        if (root is null) return 0;

        int totalSum = 0;
        Queue<BinaryTreeNode<int>> queue = new(); // BFS
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            totalSum += node.Value; // pre order

            if (node.Left is not null)
                queue.Enqueue(node.Left);

            if (node.Right is not null)
                queue.Enqueue(node.Right);
        }

        return totalSum;
    }
}

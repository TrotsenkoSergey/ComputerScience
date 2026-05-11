using Trees;

namespace BinaryTree;

public class MaxSumPathEveryNodeSolution
{
    /* 124. Binary Tree Maximum Path Sum https://leetcode.com/problems/binary-tree-maximum-path-sum/description/
        
    A path in a binary tree is a sequence of nodes where each pair of adjacent nodes in the sequence has an edge connecting them. 
    A node can only appear in the sequence at most once. Note that the path does not need to pass through the root.

    The path sum of a path is the sum of the node's values in the path.

    Given the root of a binary tree, return the maximum path sum of any non-empty path.
    */
    
    /*
    Найти максимальную сумму пути (необязательно от root -> leaf).
    Числа могут быть отрицательными.
    */

    private int _answer;
    public int MaxSumPathEveryNode(BinaryTreeNode<int>? tree) 
    {
        MaxPathSum(tree);
        return _answer;
    }

    private int MaxPathSum(BinaryTreeNode<int>? node)
    {
        if (node is null) return 0;

        int leftPathSum = Math.Max(MaxPathSum(node.Left), 0); // исключаем отрицательные значения
        int rightPathSum = Math.Max(MaxPathSum(node.Right), 0);

        int parentAndChildSum = leftPathSum + rightPathSum + node.Value;
        _answer = Math.Max(_answer, parentAndChildSum);

        return Math.Max(leftPathSum, rightPathSum) + node.Value;
    }
}

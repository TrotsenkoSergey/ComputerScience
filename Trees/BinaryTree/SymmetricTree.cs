namespace BinaryTree;

/*
 
    101. Symmetric Tree https://leetcode.com/problems/symmetric-tree/description/

Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).


Example 1:
Input: root = [1,2,2,3,4,4,3]
Output: true

Example 2:
Input: root = [1,2,2,null,3,null,3]
Output: false

Constraints:

The number of nodes in the tree is in the range [1, 1000].
-100 <= Node.val <= 100

 */

public class SymmetricTree
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root is null) return false;

        return IsMirror(root.left, root.right);
    }

    private bool IsMirror(TreeNode left, TreeNode right)
    {
        bool leftIsNull = left is null;
        bool rightIsNull = right is null;

        if (leftIsNull && rightIsNull) // если оба значения null
        {
            return true;
        }
        else if (
            leftIsNull && !rightIsNull
        || !leftIsNull && rightIsNull // если одно из значений null
        || left.val != right.val
        )
        {
            return false;
        }
        else
        {
            return IsMirror(left.left, right.right) && IsMirror(left.right, right.left);
        }
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

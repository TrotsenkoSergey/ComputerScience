namespace BinaryTree;

public class SameTree
{
    /* 100. Same Tree https://leetcode.com/problems/same-tree/description/
    
    Given the roots of two binary trees p and q, write a function to check if they are the same or not.
    Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
    
    Example 1:
    Input: p = [1,2,3], q = [1,2,3]
    Output: true
    
    Example 2:
    Input: p = [1,2], q = [1,null,2]
    Output: false
    
    Example 3:
    Input: p = [1,2,1], q = [1,1,2]
    Output: false
 
    Constraints:
    The number of nodes in both trees is in the range [0, 100].
    -104 <= Node.val <= 104
 
     */

    // beats 100% 
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        bool pIsNull = p is null;
        bool qIsNull = q is null;

        if (pIsNull && qIsNull) return true;
        if (pIsNull || qIsNull) return false;

        Stack<TreeNode> pStack = [];
        Stack<TreeNode> qStack = [];

        pStack.Push(p!);
        qStack.Push(q!);

        while (pStack.Count > 0)
        {
            TreeNode pCurrent = pStack.Pop();
            TreeNode qCurrent = qStack.Pop();

            if (pCurrent.val != qCurrent.val) return false;

            bool pLeftExist = pCurrent.left is not null;
            bool qLeftExist = qCurrent.left is not null;
            if (pLeftExist ^ qLeftExist) return false; // XOR

            bool pRightExist = pCurrent.right is not null;
            bool qRightExist = qCurrent.right is not null;
            if (pRightExist ^ qRightExist) return false; // XOR

            if (pLeftExist) 
            {
                pStack.Push(pCurrent.left!);
                qStack.Push(qCurrent.left!);
            }

            if (pRightExist) 
            {
                pStack.Push(pCurrent.right!);
                qStack.Push(qCurrent.right!);
            }
        }

        return true;
    }

    // beats 5.82% 
    public bool IsSameTree2(TreeNode p, TreeNode q)
    {
        var stack = new Stack<(TreeNode, TreeNode)>();
        stack.Push((p, q));

        while (stack.Count > 0)
        {
            var (nodeP, nodeQ) = stack.Pop();

            if (nodeP is null && nodeQ is null) continue;
            if (nodeP is null || nodeQ is null) return false;
            if (nodeP.val != nodeQ.val) return false;

            stack.Push((nodeP.left, nodeQ.left));
            stack.Push((nodeP.right, nodeQ.right));
        }

        return true;
    }
}

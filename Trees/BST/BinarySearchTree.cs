using Trees;

namespace BST;

public class BinarySearchTree
{
    public BinaryTreeNode<int>? Root { get; private set; }

    public void Insert(int value) 
    {
        BinaryTreeNode<int> node = new(value);
        if (Root == null)
        {
            Root = node;
        }
        else 
        {
            Insert(Root, node);
        }
    }

    private void Insert(BinaryTreeNode<int> root, BinaryTreeNode<int> node) 
    {
        if (node.Value < root.Value)
        {
            if (root.Left is null)
            {
                root.Left = node;
            }
            else
            {
                Insert(root.Left, node);
            }
        }
        else // node.Value > root.Value
        {
            if (root.Right is null)
            {
                root.Right = node;
            }
            else 
            { 
                Insert(root.Right, node);
            }
        }
    }

    public void Remove(BinaryTreeNode<int> node) 
    { 

    }
}

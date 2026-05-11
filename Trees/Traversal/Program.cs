using Traversal;
using Trees;

internal class Program
{

    private static void Main(string[] args)
    {
     /*
                    a
                  /   \
                 b     c
                / \     \
               d   e     f
    */
        BinaryTreeNode<string> root = new("a");
        BinaryTreeNode<string> b = new("b");
        BinaryTreeNode<string> c = new("c");
        BinaryTreeNode<string> d = new("d");
        BinaryTreeNode<string> e = new("e");
        BinaryTreeNode<string> f = new("f");

        root.Left = b;
        b.Left = d;
        b.Right = e;

        root.Right = c;
        c.Right = f;

        var dfsTraverse = new DFS();
        dfsTraverse.Traverse(root);

        var bfsTraverse = new BFS();
        bfsTraverse.Traverse(root);
    }
}
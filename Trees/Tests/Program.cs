
using BinaryTree;

var sameTree = new SameTree();

TreeNode p1 = new(1);
TreeNode q1 = new(1);
p1.left = new TreeNode(2);
q1.left = new TreeNode(2);
p1.right = new TreeNode(3);
q1.right = new TreeNode(3);

bool result1 = sameTree.IsSameTree(p1, q1);

TreeNode p2 = new(1);
TreeNode q2 = new(1);
p2.left = new TreeNode(2);
q2.right = new TreeNode(2);

bool result2 = sameTree.IsSameTree(p2, q2);

TreeNode p3 = new(1);
TreeNode q3 = new(1);
p3.left = new TreeNode(2);
q3.left = new TreeNode(1);
p3.right = new TreeNode(1);
q3.right = new TreeNode(2);

bool result3 = sameTree.IsSameTree(p3, q3);


Console.ReadLine();

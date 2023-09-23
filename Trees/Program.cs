// C#
class Node
{
    Node? left, right;
    int data;

    public Node(int data)
    {
        this.data = data;
    }

    public void Insert(int value)
    {
        if (value <= data)
        {
            if (left == null)
                left = new Node(value);
            else
                left.Insert(value); 
        }
        else
        {
            if (right == null)
                right = new Node(value);
            else
                right.Insert(value);
        }
    }

    public Boolean Contains(int value)
    {
        if (value == data) return true;
        if (value < data)
        {
            if (left == null)
                return false;
            else
                return left.Contains(value);
        }
        if (value > data)
        {
            if (right == null)
                return false;
            else
                return right.Contains(value);
        }
        return false;
    }

    public void PrintInOrder()
    {
        if (left != null) left.PrintInOrder();
        Console.WriteLine(data);

        if (right != null) right.PrintInOrder();
        Console.WriteLine(data);
    }

}



 //Definition for a binary tree node.
 public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
 }

public class Solution
{
    //Create list to store in order binary tree traversal
    private List<int> nodes = new List<int>();
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root == null)
            return new List<int>();
        if (root.left == null && root.right == null)
            return new List<int> { root.val };
        TraverseTreeInternal(root);
        return nodes;
    }
    private void TraverseTreeInternal(TreeNode node)
    {
        if (node == null) return;
        TraverseTreeInternal(node.left);
        nodes.Add(node.val);
        TraverseTreeInternal(node.right);
    }
}
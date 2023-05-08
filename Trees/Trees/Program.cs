// https://www.c-sharpcorner.com/article/tree-data-structure/
// Create a blank Binary Tree
public class BinaryTreeByLinkedList
{
    BinaryNode root;

    // Create a constructor
    public BinaryTreeByLinkedList()
    {
        this.root = null;
    }

    // Pre-order traversal of binary tree
    void preOrder (BinaryNode node)
    {
        if (node == null)
        {
            return;
        }
        Console.WriteLine(node.getValue() + " ");
        preOrder(node.getLeft());
        preOrder(node.getRight());
    }

    void levelOrder()
    {
        // Make a queue for level order. Queue is Interface and LinkedList is class
        Queue<BinaryNode> queue = new LinkedList<BinaryNode>();
        queue.add(root);
        while (!queue.isEmpty())
        {
            BinaryNode presentNode = queue.remove();
            Console.WriteLine(presentNode.getValue() + "");
            if (presentNode.getLeft() != null)
            {
                queue.add(presentNode.getLeft());
            }
            if (presentNode.getRight() != null)
            {
                queue.add(presentNode.getRight());
            }
        }
    }
}
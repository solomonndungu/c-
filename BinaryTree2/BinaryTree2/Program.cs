// Delete deepest node

public void DeleteDeepestNode()
{
    Queue<BinaryNode> queue = new LinkedList<BinaryNode>();
    queue.add(root);

    BinaryNode previousNode, presentNode = null;

    while (!queue.isEmpty())
    {
        previousNode = presentNode;
        presentNode = queue.remove();

        if(presentNode.getLeft() == null)
        {
            previousNode.setRight(null);
            return;
        }else if ((presentNode.getRight() == null)) {
            presentNode.setLeft(null);
            return;
        }
        queue.add(presentNode.getLeft());
        queue.add(presentNode.getRight());
    }

}

public BinaryNode getDeepestNode()
{
    // Make an empty queue. Queue is Interface and LinkedList is class
    Queue<BinaryNode> queue = new LinkedList<BinaryNode>();
    queue.add(root);

    BinaryNode presentNode = null;

    while (!queue.isEmpty())
    {
        presentNode = queue.remove();

        if (presentNode.getLeft() != null)
        {
            queue.add(presentNode.getLeft());
        }

        if (presentNode.getRight() != null)
        {
            queue.add(presentNode.getRight());
        }
    }
    return presentNode;

}

// Code to Delete a value from BinaryTree
void deleteNodeofBinaryTree(int value)
{
    Queue<BinaryNode> queue = new LinkedList<BinaryNode>();
    queue.add(root);

    while (!queue.isEmpty())
    {
        BinaryNode presentNode = queue.remove();

        // if node is found then copy deepest node here and delete deepest node

        if (presentNode.getValue() == value)
        {
            presentNode.setValue(getDeepestNode().getValue());
            DeleteDeepestNode();

            Console.WriteLine("Deleted the node !!");
            return;
        }else
        {
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
    Console.WriteLine("Did not find the node !!");
}

// Delete Entire Binary Tree
void deleteTree()
{
    root = null;
    Console.WriteLine("Binary Tree has been deleted successfully");
}
// Breadth First Search
// Search for a given value in binary tree
void search (int value)
{
    Queue<BinaryNode> queue = new LinkedList<BinaryNode>();
    queue.add(root);

    while (!queue.isEmpty())
    {
        BinaryNode presentNode = queue.remove();

        if (presentNode.getValue() == value)
        {
            Console.WriteLine("Value- " + value + " is found in Tree !");
            return;
        }else
        {
            if (presentNode.getLeft()! = null)
            {
                queue.add(presentNode.getLeft());
            }
            if (presentNode.getRight() != null)
            {
                queue.add(presentNode.getRight());
            }
        } 
        Console.WriteLine("Value- "+value+" is not found in Tree !");
    }
}

// Insert a new node at deepest place in Tree
void insert (int value)
{
    BinaryNode node = new BinaryNode();
    node.setValue(value);

    if (root == null)
    {
        root = node;
        Console.WriteLine("Successfully inserted new node at Root!");
        return;
    }
    Queue<BinaryNode> queue = new LinkedList<BinaryNode>();
    queue.add(root);
    while (!queue.isEmpty())
    {
        BinaryNode presentNode = queue.remove();

        if (presentNode.getLeft() == null)
        {
            presentNode.setLeft(node);
            Console.WriteLine("Successfully inserted new node !");
            break;
        }else if (presentNode.getRight() == null)
        {
            presentNode.setRight(node);

            Console.WriteLine("Successfully inserted new node !");
            break;
        } else
        {
            queue.add(presentNode.getLeft());
            queue.add(presentNode.getRight());
        }
    }
}
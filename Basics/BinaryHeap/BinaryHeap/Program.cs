// https://www.c-sharpcorner.com/article/binary-heap-in-c-sharp/
// Create a blank heap
public class BinaryHeapExample
{
    int[] arr;
    int sizeOfTree;

    public BinaryHeapExample(int size)
    {
        int[] arr = new int[size + 1];
        this.sizeOfTree = 0;
        Console.WriteLine("Empty heap has been created.");
    }

    // Insert value in heap
    public void InsertElementInHeap(int value)
    {
        if (sizeOfTree < 0)
        {
            Console.WriteLine("Tree is empty");
        }
        else
        {
            // Insertion in array happens at the last index array
            arr[sizeOfTree + 1] = value;
            sizeOfTree++;
        }
        HeapifyBottomToTop(sizeOfTree);
        Console.WriteLine("Inserted " + value + " successfully in Heap!");

        levelOrder();
    }

        public void HeapifyBottomToTop(int index)
    {
        int parent = index / 2;
        if (index <= 1)
        {
            return;
        }
        // If current value is smaller than parent, we swap
        if (arr[index] < arr[parent])
        {
            int tmp = arr[index];
            arr[index] = arr[parent];
            arr[parent] = tmp;
        }
        HeapifyBottomToTop(parent);
    }
    public void levelOrder()
    {
        Console.WriteLine("Printing all the elements of this Heap...");

        for (int i = 1; i <= sizeOfTree; i++)
        {
            Console.WriteLine(arr[i] + "");
        }
        Console.WriteLine("\n");
    }

    // Extract a value from Heap
    public int extractHeadofHeap() // Extract head of heap
    {
        if(sizeOfTree == 0)
        {
            Console.WriteLine("Heap is empty!");
            return -1;
        }else
        {
            Console.WriteLine("Head of Heap is:" + arr[1]);
            Console.WriteLine("Extracting it now...");

            int extractedValue = arr[1];
            arr[1] = arr[sizeOfTree]; // Replacing with last element of array
            sizeOfTree--;

            HeapifyTopToBottom(1);
            Console.WriteLine("Successfully extracted value from Heap.");

            levelOrder();

            return extractedValue;
        }
    }

    public void HeapifyTopToBottom(int index)
    {
        int left = index * 2;
        int right = (index * 2) + 1;
        int smallestChild = 0;

        // If there is no child of this node, then nothing to do. Just return.
        if (sizeOfTree < left)
        {
            return;
        }
        // If there is only left child, do a comparison and return.
        else if (sizeOfTree == left)
        {
            if (arr[index] > arr[left])
            {
                int tmp = arr[index];
                arr[index] = arr[left];
                arr[left] = tmp;
            }
            return;
        }
        // If both children are there
        else
        {
            if (arr[left] < arr[right])
            {
                smallestChild = left;
            }else
            {
                smallestChild = right;
            }
            // If parent is greater than smallest child, then swap
            if (arr[index] > arr[smallestChild])
            {
                int tmp = arr[index];
                arr[index] = arr[smallestChild];
                arr[smallestChild] = tmp;
            }
        }
        HeapifyTopToBottom(smallestChild);
    }

}
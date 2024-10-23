public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true; // Value found
        }
        else if (value < Data && Left != null)
        {
            return Left.Contains(value); // Search left subtree
        }
        else if (value > Data && Right != null)
        {
            return Right.Contains(value); // Search right subtree
        }
        return false; // Value not found
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int leftHeight = Left?.GetHeight() ?? 0;  // Get height of left subtree or 0 if null
        int rightHeight = Right?.GetHeight() ?? 0; // Get height of right subtree or 0 if null

        return 1 + Math.Max(leftHeight, rightHeight); // Height of current node is 1 + max(left, right)
    }
}
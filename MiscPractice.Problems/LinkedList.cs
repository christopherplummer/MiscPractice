namespace MiscPractice.Problems;
public class LinkedList<T> 
{
    public Node<T> Head { get; set; }

    public int Count() 
    {
        if (Head is null) return 0;
        if (Head.Next is null) return 1;
        var tail = FindTail(Head.Next);
        return tail.Position + 1;
    }

    public void InsertAtBeginning(T item) 
    {
        if (Head is null) 
        {
            Head = new Node<T> {Position = 0, Data = item};
            return;
        }

        var temp = new Node<T> {Position = 0, Data = item};
        temp.Next = Head;
        temp.Next.Position++;
        Head = temp;
        IncrementPositions(Head.Next.Next);
        return;
    }

    public void InsertAtEnd(T item) 
    {
        if (Head is null) 
        {
            Head = new Node<T> {Position = 0, Data = item};
            return;
        }
        else if (Head.Next is null) 
        {
            Head.Next = new Node<T> {Position = 1, Data = item};
            return;
        }
        var tail = FindTail(Head.Next);
        tail.Next = new Node<T> { Position = tail.Position + 1, Data = item };
    }

    public bool Remove(T item) 
    {
        return false;
    }

    public Node<T> FindNodeByPosition(int position)
    {
        if (position == 0) return Head;
        if (position == 1) return Head?.Next;
        if (position == 2) return Head?.Next?.Next;

        var foundNode = false;
        Node<T> targetNode = Head?.Next?.Next?.Next;
        while (!foundNode)
        {
            if (targetNode is null || targetNode.Position == position) 
            {
                foundNode = true;
                break;
            }

            targetNode = targetNode.Next;
        }
        return targetNode;
    }

#region Private Methods
    private Node<T> FindTail(Node<T> node)
    {
        return node.Next is null ? node : FindTail(node.Next);
    }

    private void IncrementPositions(Node<T> node)
    {
        if (node is null) return;
        node.Position++;
        IncrementPositions(node.Next);
    }
#endregion
}

public class Node<T>
{
    public int Position { get; set; }
    public T Data { get; set; }
    public Node<T> Next { get; set; }
}

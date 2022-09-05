public class LinkedList<T> 
{
    public Node<T> Head { get; set; }

    public int Count() 
    {
        return 0;
    }
}

public class Node<T>
{
    public int Position { get; set; }
    public T Data { get; set; }
    public T Next { get; set; }
}
namespace Backend;

//Create a node structure that save a data and connects via 'Next' and 'Prev'.
public class DoubleNode<T>
{
    public T Data { get; set; }

    public DoubleNode<T>? Prev { get; set; }

    public DoubleNode<T>? Next { get; set; }

    public DoubleNode(T data)
    {
        Data = data;
        Prev = null;
        Next = null;
    }
}
namespace Backend;

//The list structure is created without implementing any operations

public class DoubleLinkedList<T>
{
    private DoubleNode<T>? head;
    private DoubleNode<T>? tail;

    public DoubleLinkedList()
    {
        head = null;
        tail = null;
    }

    //Method tha Insert a new node at the beginning of the list
    public void InsertFirst(T data)
    {
        DoubleNode<T> newNode = new DoubleNode<T>(data);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
            return;
        }

        newNode.Next = head;
        head.Prev = newNode;
        head = newNode;
    }


    //Insert a new node at the end of the list.
    public void InsertLast(T data)
    {
        DoubleNode<T> newNode = new DoubleNode<T>(data);

        if (tail == null)
        {
            head = newNode;
            tail = newNode;
            return;
        }

        tail.Next = newNode;
        newNode.Prev = tail;
        tail = newNode;
    }

    
    // Show the list from first to last.
    public override string ToString()
    {
        string output = "";
        DoubleNode<T>? current = head;

        while (current != null)
        {
            output += current.Data + " <-> ";
            current = current.Next;
        }

        output += "null";
        return output;
    }


    // Show the list from last to first.
    public string ShowReverse()
    {
        string output = "";
        DoubleNode<T>? current = tail;

        while (current != null)
        {
            output += current.Data + " <-> ";
            current = current.Prev;
        }

        output += "null";
        return output;
    }



}

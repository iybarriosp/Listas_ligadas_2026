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


    // Insert data in ascending order.
    public void Insert(T data)
    {
        OrderAsc();
        
        DoubleNode<T> newNode = new DoubleNode<T>(data); ////Create a node with the data entered by the user.

        if (head == null)
        {
            head = newNode; // Check if the list is empty. If it is, the new node becomes the head and the tail.
            tail = newNode;
            return;
        }

        DoubleNode<T>? current = head; //Use `current` to traverse the list and find where the new value should be placed.

        while (current != null &&
               Comparer<T>.Default.Compare(current.Data, data) <= 0) //compare values ​​of different types
        {
            current = current.Next;
        }

        if (current == head) 
        {
            InsertFirst(data);
            return;
        }

        if (current == null)
        {
            InsertLast(data);
            return;
        }

        newNode.Prev = current.Prev;
        newNode.Next = current;
        current.Prev!.Next = newNode;
        current.Prev = newNode;
    }

     // Order the list from mayor to menor.
    
    public void OrderDesc()
    {
        if (head == null || head == tail)
        {
            return;
        }

        if (Comparer<T>.Default.Compare(head.Data, tail!.Data) > 0) //check whether the first element is greater than the last. If it is already in descending order, avoid reversing it again.
        {
            return;
        }

        DoubleNode<T>? current = head;

        while (current != null)
        {
            DoubleNode<T>? nextNode = current.Next;

            current.Next = current.Prev;
            current.Prev = nextNode;

            current = nextNode;
        }

        DoubleNode<T>? temp = head;
        head = tail;
        tail = temp;
    }


    // Order the list from menor to mayor
    public void OrderAsc()
    {
        if (head == null || head == tail)
        {
            return;
        }

        if (Comparer<T>.Default.Compare(head.Data, tail!.Data) <= 0)
        {
            return;
        }

        DoubleNode<T>? current = head;

        while (current != null)
        {
            DoubleNode<T>? nextNode = current.Next;

            current.Next = current.Prev;
            current.Prev = nextNode;

            current = nextNode;
        }

        DoubleNode<T>? temp = head;
        head = tail;
        tail = temp;
    }



}

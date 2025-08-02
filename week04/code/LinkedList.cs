using System.Collections;

public class LinkedList : IEnumerable<int>
{
    private Node? _head;
    private Node? _tail;

    /// <summary>
    /// Insert a new node at the front (i.e. the head) of the linked list.
    /// </summary>
    public void InsertHead(int value)
    {
        // Create new node
        Node newNode = new(value);
        // If the list is empty, then point both head and tail to the new node.
        if (_head is null)
        {
            _head = newNode;
            _tail = newNode;
        }
        // If the list is not empty, then only head will be affected.
        else
        {
            newNode.Next = _head; 
            _head.Prev = newNode; 
            _head = newNode; 
        }
    }

    /// <summary>
    /// Insert a new node at the back (i.e. the tail) of the linked list.
    /// </summary>
    public void InsertTail(int value)
    {
        // Create a new node
        Node newNode = new(value);
        
        // If the list is empty, the new node is both the head and the tail
        if (_tail is null)
        {
            _head = newNode;
            _tail = newNode;
        }
        // If the list is not empty, connect the new node after the current tail
        else
        {
            _tail.Next = newNode; 
            newNode.Prev = _tail; 
            _tail = newNode;      
        }
    }


    /// <summary>
    /// Remove the first node (i.e. the head) of the linked list.
    /// </summary>
    public void RemoveHead()
    {
        // If the list has only one item in it, then set head and tail 
        // to null resulting in an empty list.  This condition will also
        // cover an empty list.  Its okay to set to null again.
        if (_head == _tail)
        {
            _head = null;
            _tail = null;
        }
        // If the list has more than one item in it, then only the head
        // will be affected.
        else if (_head is not null)
        {
            _head.Next!.Prev = null; 
            _head = _head.Next; 
        }
    }


    /// <summary>
    /// Remove the last node (i.e. the tail) of the linked list.
    /// </summary>
    public void RemoveTail()
    {
        // If the list has one or zero nodes, clearing it is the same as removing the head.
        if (_head == _tail)
        {
            _head = null;
            _tail = null;
        }
        // If the list has more than one node, only the tail is affected.
        else if (_tail is not null)
        {
            _tail.Prev!.Next = null; 
            _tail = _tail.Prev;      
        }
    }

    /// <summary>
    /// Insert 'newValue' after the first occurrence of 'value' in the linked list.
    /// </summary>
    public void InsertAfter(int value, int newValue)
    {
        // Search for the node that matches 'value' by starting at the 
        // head of the list.
        Node? curr = _head;
        while (curr is not null)
        {
            if (curr.Data == value)
            {
                // If the location of 'value' is at the end of the list,
                // then we can call insert_tail to add 'new_value'
                if (curr == _tail)
                {
                    InsertTail(newValue);
                }
                // For any other location of 'value', need to create a 
                // new node and reconnect the links to insert.
                else
                {
                    Node newNode = new(newValue);
                    newNode.Prev = curr; 
                    newNode.Next = curr.Next; 
                    curr.Next!.Prev = newNode; 
                    curr.Next = newNode; 
                }

                return; // We can exit the function after we insert
            }

            curr = curr.Next; // Go to the next node to search for 'value'
        }
    }

    /// <summary>
    /// Remove the first node that contains 'value'.
    /// </summary>
    public void Remove(int value)
    {
        // Start searching from the head
        Node? curr = _head;
        while (curr is not null)
        {
            // If we find the value
            if (curr.Data == value)
            {
                // Case 1: The node to remove is the head
                if (curr == _head)
                {
                    RemoveHead();
                }
                // Case 2: The node to remove is the tail
                else if (curr == _tail)
                {
                    RemoveTail();
                }
                // Case 3: The node is in the middle
                else
                {
                    // Bypass the current node
                    curr.Prev!.Next = curr.Next;
                    curr.Next!.Prev = curr.Prev;
                }
                // Exit the function after removing the first match
                return;
            }
            // Move to the next node
            curr = curr.Next;
        }
    }

    /// <summary>
    /// Search for all instances of 'oldValue' and replace the value to 'newValue'.
    /// </summary>
    public void Replace(int oldValue, int newValue)
    {
        // Start at the head
        Node? curr = _head;
        // Iterate through the entire list
        while (curr is not null)
        {
            // If the node's data matches oldValue, replace it
            if (curr.Data == oldValue)
            {
                curr.Data = newValue;
            }
            // Move to the next node
            curr = curr.Next;
        }
    }

    /// <summary>
    /// Yields all values in the linked list
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
        // call the generic version of the method
        return this.GetEnumerator();
    }

    /// <summary>
    /// Iterate forward through the Linked List
    /// </summary>
    public IEnumerator<int> GetEnumerator()
    {
        var curr = _head; 
        while (curr is not null)
        {
            yield return curr.Data;
            curr = curr.Next; // Go forward in the linked list
        }
    }

    /// <summary>
    /// Iterate backward through the Linked List
    /// </summary>
    public IEnumerable Reverse()
    {
        // Start at the tail for reverse iteration
        var curr = _tail;
        while (curr is not null)
        {
            // Yield the current node's data
            yield return curr.Data;
            // Move to the previous node
            curr = curr.Prev;
        }
    }

    public override string ToString()
    {
        return "<LinkedList>{" + string.Join(", ", this) + "}";
    }

    // Just for testing.
    public Boolean HeadAndTailAreNull()
    {
        return _head is null && _tail is null;
    }

    // Just for testing.
    public Boolean HeadAndTailAreNotNull()
    {
        return _head is not null && _tail is not null;
    }
}

using System;

class Node
{
    public int EmployeeID;
    public string Name;
    public Node Next;

    public Node(int id, string name)
    {
        EmployeeID = id;
        Name = name;
        Next = null;
    }
}

class EmployeeLinkedList
{
    private Node head;

    // Insert at beginning
    public void InsertAtBeginning(int id, string name)
    {
        Node newNode = new Node(id, name);
        newNode.Next = head;
        head = newNode;
    }

    // Insert at end
    public void InsertAtEnd(int id, string name)
    {
        Node newNode = new Node(id, name);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    // Delete by Employee ID
    public void DeleteByID(int id)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        // If head needs to be deleted
        if (head.EmployeeID == id)
        {
            head = head.Next;
            return;
        }

        Node temp = head;
        while (temp.Next != null && temp.Next.EmployeeID != id)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            Console.WriteLine($"Employee with ID {id} not found.");
        }
        else
        {
            temp.Next = temp.Next.Next;
        }
    }

    // Traverse and display
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("Employee list is empty.");
            return;
        }

        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.EmployeeID} - {temp.Name}");
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        EmployeeLinkedList list = new EmployeeLinkedList();

        // Sample Input: Insert employees
        list.InsertAtEnd(101, "John");
        list.InsertAtEnd(102, "Sara");
        list.InsertAtEnd(103, "Mike");

        // Delete employee with ID 102
        list.DeleteByID(102);

        // Display after deletion
        Console.WriteLine("Employee List After Deletion:");
        list.Display();
    }
}

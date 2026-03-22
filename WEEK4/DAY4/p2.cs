using System;

class StackUndo
{
    private string[] stack;   // array to hold actions
    private int top;          // index of top element

    // Constructor
    public StackUndo(int size)
    {
        stack = new string[size];
        top = -1;
    }

    // Push (add action)
    public void Push(string action)
    {
        if (top == stack.Length - 1)
        {
            Console.WriteLine("Stack overflow! Cannot add more actions.");
            return;
        }
        stack[++top] = action;
        DisplayCurrentState();
    }

    // Pop (undo action)
    public void Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack underflow! No actions to undo.");
            return;
        }
        Console.WriteLine($"Undo: {stack[top]}");
        top--;
        DisplayCurrentState();
    }

    // Display current state
    public void DisplayCurrentState()
    {
        if (top == -1)
        {
            Console.WriteLine("Current State: [Empty]");
            return;
        }

        Console.Write("Current State: ");
        for (int i = 0; i <= top; i++)
        {
            Console.Write(stack[i] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        StackUndo editor = new StackUndo(10);

        // Sample Input: Type A, Type B, Type C, Undo, Undo
        editor.Push("Type A");
        editor.Push("Type B");
        editor.Push("Type C");
        editor.Pop();
        editor.Pop();
    }
}

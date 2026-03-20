using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        MinStack obj = new MinStack();
        obj.Push(-2);
        obj.Push(0);
        obj.Push(-3);
        Console.WriteLine(obj.GetMin());
        obj.Pop();
        Console.WriteLine(obj.Top());
        Console.WriteLine(obj.GetMin());
    }
}
public class MinStack
{
    Stack<int> stack;
    Stack<int> minStack;
    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        if (minStack.Count > 0)
        {
            if (minStack.Peek() >= val)
            {
                minStack.Push(val);
            }
        }
        else
        {
            minStack.Push(val);
        }
        stack.Push(val);
    }

    public void Pop()
    {
        int val = stack.Pop();
        if (minStack.Count > 0 && val == minStack.Peek())
        {
            minStack.Pop();
        }
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}
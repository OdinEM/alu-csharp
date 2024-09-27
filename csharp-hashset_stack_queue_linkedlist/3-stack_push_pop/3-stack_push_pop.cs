using System;
using System.Collections.Generic;

class MyStack
{
    static void Main(string[] args)
    {
        Stack<string> aStack = new Stack<string>();

        aStack.Push("C");
        aStack.Push("HTML");
        aStack.Push("Javascript");
        aStack.Push("Python");
        aStack.Push("React");
        aStack.Push("Ruby");

        foreach (string item in aStack)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyStack.Info(aStack, "C#", "Javascript");

        Console.WriteLine("------");

        foreach (string item in aStack)
            Console.WriteLine(item);
    }

    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");

        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }

        Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");

        // Remove the searched item from the stack if it exists
        Stack<string> tempStack = new Stack<string>();
        while (aStack.Count > 0)
        {
            string topItem = aStack.Pop();
            if (topItem != search)
            {
                tempStack.Push(topItem); // Keep only non-matching items
            }
        }

        // Restore the remaining items back to the original stack
        while (tempStack.Count > 0)
        {
            aStack.Push(tempStack.Pop());
        }

        // Push the new item onto the stack
        aStack.Push(newItem);

        return aStack;
    }
}

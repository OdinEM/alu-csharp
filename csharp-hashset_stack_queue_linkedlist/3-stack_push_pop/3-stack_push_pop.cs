﻿using System;
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

        Console.WriteLine($"Stack contains \"{search}\" : {aStack.Contains(search)}");

        // Create a temporary stack to hold items
        Stack<string> tempStack = new Stack<string>();

        // Remove the searched item by popping the stack
        while (aStack.Count > 0)
        {
            string top = aStack.Pop();
            if (top != search)
            {
                tempStack.Push(top);
            }
        }

        // Restore items back into the original stack
        while (tempStack.Count > 0)
        {
            aStack.Push(tempStack.Pop());
        }

        // Push the new item onto the stack
        aStack.Push(newItem);

        return aStack;
    }
}

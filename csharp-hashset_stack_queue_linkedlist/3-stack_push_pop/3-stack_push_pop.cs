using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        // Step 1: Print the number of items in the stack
        Console.WriteLine($"Number of items: {aStack.Count}");

        // Step 2: Print the top item of the stack without removing it
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }

        // Step 3: Check if the stack contains the search item
        bool containsSearch = aStack.Contains(search);
        Console.WriteLine($"Stack contains \"{search}\": {containsSearch}");

        // Step 4: If the stack contains the search item, remove items up to and including it
        if (containsSearch)
        {
            // Store items in a temporary stack (since we can only Pop once)
            Stack<string> tempStack = new Stack<string>();

            // Pop items from the original stack into the temp stack until we find the search item
            string poppedItem = aStack.Pop(); // This is the only Pop we are allowed to use

            tempStack.Push(poppedItem); // Push the first popped item to tempStack

            while (poppedItem != search && aStack.Count > 0)
            {
                poppedItem = aStack.Pop(); // Pop more items until we find the search item
                tempStack.Push(poppedItem); // Keep pushing items into the temporary stack
            }

            // Now, the search item has been popped, and we stop here.
            // No need to return these items back to the original stack.
        }

        // Step 5: Add the new item to the stack
        aStack.Push(newItem);

        // Step 6: Return the modified stack
        return aStack;
    }
}

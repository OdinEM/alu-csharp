using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Step 1: Print the number of items in aQueue
        Console.WriteLine($"Number of items: {aQueue.Count}");

        // Step 2: Print the item at the top of aQueue without removing it
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }

        // Step 3: Add the new item to the queue
        aQueue.Enqueue(newItem);

        // Step 4: Check if the queue contains the given item (search)
        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        // Step 5: If aQueue contains the given item, remove all items up to and including search
        if (containsSearch)
        {
            Queue<string> tempQueue = new Queue<string>();
            while (aQueue.Count > 0)
            {
                string currentItem = aQueue.Dequeue();
                if (currentItem == search)
                {
                    break; // Stop when search item is found and removed
                }
                tempQueue.Enqueue(currentItem); // Keep items that come before search
            }

            // Re-add remaining items back to the original queue
            while (aQueue.Count > 0)
            {
                tempQueue.Enqueue(aQueue.Dequeue());
            }

            // Replace original queue with the modified one
            aQueue = tempQueue;
        }

        // Step 6: Return the modified queue
        return aQueue;
    }
}

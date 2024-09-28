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

        // Step 5: If aQueue contains the search item, remove up to and including search using a single Dequeue
        if (containsSearch)
        {
            // Use Dequeue only once to get the first item
            string firstItem = aQueue.Dequeue();

            // Create a temporary list to hold the remaining items
            List<string> tempList = new List<string>();
            tempList.Add(firstItem); // Add the first item we just dequeued

            // Dequeue only once, now iterate over the rest of the queue
            while (aQueue.Count > 0)
            {
                string currentItem = aQueue.Peek();
                if (currentItem == search)
                {
                    aQueue.Dequeue(); // Remove the search item and stop
                    break;
                }
                else
                {
                    tempList.Add(aQueue.Dequeue());
                }
            }

            // Add remaining items back to the queue
            foreach (var item in tempList)
            {
                aQueue.Enqueue(item);
            }
        }

        // Step 6: Return the modified queue
        return aQueue;
    }
}

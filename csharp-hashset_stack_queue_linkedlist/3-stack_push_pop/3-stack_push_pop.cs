using System;
using System.Collections.Generic;

namespace StackImplementation
{
    public class MyStack<T>
    {
        private List<T> stack = new List<T>();

        public void Push(T item)
        {
            stack.Add(item);
        }

        public T Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T item = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return item;
        }

        public int Count
        {
            get { return stack.Count; }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();

            Console.WriteLine("Pushing elements onto the stack:");
            for (int i = 1; i <= 5; i++)
            {
                stack.Push(i);
                Console.WriteLine($"Pushed: {i}");
            }

            Console.WriteLine($"\nStack count: {stack.Count}");

            Console.WriteLine("\nPopping elements from the stack:");
            while (stack.Count > 0)
            {
                int popped = stack.Pop();
                Console.WriteLine($"Popped: {popped}");
            }

            Console.WriteLine($"\nFinal stack count: {stack.Count}");
        }
    }
}
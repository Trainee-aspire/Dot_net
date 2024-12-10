using System;
using System.Collections.Concurrent;

class Program
{
    static void Main()
    {
        ConcurrentStack<string> stack = new ConcurrentStack<string>();

        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");

        if (stack.TryPop(out string result))
        {
            Console.WriteLine($"Popped: {result}");
        }

        if (stack.TryPeek(out string top))
        {
            Console.WriteLine($"Top element: {top}");
        }

        stack.PushRange(new string[] { "Fourth", "Fifth", "Sixth" });

        string[] range = new string[2];
        if (stack.TryPopRange(range, 0, 2) > 0)
        {
            Console.WriteLine("Popped range: " + string.Join(", ", range));
        }

        Console.WriteLine($"Count: {stack.Count}");
    }
}

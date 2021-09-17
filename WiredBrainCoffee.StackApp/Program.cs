using System;

namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackStrings();
            Console.ReadLine();
        }

        private static void StackDoubles()
        {
            var stack = new SimpleStack();
            stack.Push(1.2);
            stack.Push(3.2);
            stack.Push(4.5);
            stack.Push(9.1);

            double sum = 0.0;

            while (stack.Count > 0)
            {
                double item = (double)stack.Pop();
                Console.WriteLine($"Item : {item}");
                sum += item;
            }
            Console.WriteLine($"Sum : {sum}");
        }
        private static void StackStrings()
        {
            var stack = new SimpleStack();
            stack.Push("Weird Brain Coffee");
            stack.Push("Pluralsight");
            while (stack.Count > 0)
            {
                Console.WriteLine($"Item : {stack.Pop()}");
            }
        }
    }
}

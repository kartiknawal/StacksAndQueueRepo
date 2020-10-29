using System;

namespace StackAndQueueProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stack and queue DS program!");

            Stack stack = new Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            Console.ReadKey();
            Console.WriteLine("\n-------------------------------");
            stack.Peak();
            stack.Pop();
            stack.IsEmpty();
            stack.Display();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Asp");
            myStack.Push("Dot");
            myStack.Push("Net");
            myStack.Push("C#");
            myStack.Push("0124587xxxxxxxx");
            Console.WriteLine("My stack is :");
            foreach (string stackItem in myStack)
            {
                Console.WriteLine(stackItem);
            }
            Console.WriteLine("The size of stack : "+myStack.Count);
            myStack.Pop();
            Console.WriteLine("After Pop the stack will be : "+myStack.Count);
            Console.WriteLine("Peek a value from stack :"+myStack.Peek());
            Console.WriteLine("The size of stack after Peek a value : "+myStack.Count);
            foreach (string nowItem in myStack)
            {
                Console.WriteLine(nowItem);
            }
            Console.WriteLine(myStack.Contains("C#"));
            
            Console.ReadLine();
        }
    }
}

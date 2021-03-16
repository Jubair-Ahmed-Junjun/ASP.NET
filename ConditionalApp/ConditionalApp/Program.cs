using System;

namespace ConditionalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int aNumber = Convert.ToInt32(Console.ReadLine());
            if(aNumber%2==0)
            {
                if(aNumber==4)
                {
                    Console.WriteLine("4");
                }
                else
                {
                    Console.WriteLine("Even");
                }
            }
            else
            {
                Console.WriteLine("Odd");
            }
            Console.ReadLine();
            //Console.WriteLine("Hello World!");
        }
    }
}

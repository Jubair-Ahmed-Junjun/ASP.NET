using System;

namespace ThirtProblemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i%3==0 || i%5==0)
                {
                    //Console.WriteLine(i);
                    sum = sum + i;
                    
                }
               
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}

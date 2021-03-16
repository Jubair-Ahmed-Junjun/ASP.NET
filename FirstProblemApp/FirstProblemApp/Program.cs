using System;

namespace FirstProblemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Lower limit");
            int LL = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Upper limit");
            int uL = Convert.ToInt32(Console.ReadLine());
            for (int i = LL; i <= uL; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

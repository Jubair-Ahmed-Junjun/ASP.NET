using System;

namespace LoopsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int aNumber = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= aNumber; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();



            /* int i = 0;
               while (i<=aNumber)
               {
                   Console.WriteLine(i);
                   i++;
               }
               Console.ReadLine();
           */


            /* int i = 0;

              do
              {
                  Console.WriteLine(i);
                  i++;
              } while (i <= aNumber);
              Console.ReadLine();*/
        }
    }
}

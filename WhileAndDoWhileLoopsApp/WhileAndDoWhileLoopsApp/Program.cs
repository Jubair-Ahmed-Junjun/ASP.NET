using System;

namespace WhileAndDoWhileLoopsApp
{
    class Program
    {
        static void Main(string[] args)
        {


            /*    int i = 0;
                  while(i<=20)
                  {
                      Console.WriteLine(i);
                      i++;
                  }  
            */



            /*   int i = 0;
               while(true)
               {
                   Console.WriteLine(i);
                   if (i >= 4)
                       break;
                   i++;
               }
            */




            /*   int i = 0;
               while(i<=20)
               {
                   i++;
                   if (i % 5 == 0)
                       continue;
                   Console.WriteLine(i);
               }
              */


            int i = 0;
            do
            {
              if (i % 5 == 0)
              Console.WriteLine(i);
              i++;
            } while (i <= 20);
            
            Console.ReadKey();
        }
    }
}

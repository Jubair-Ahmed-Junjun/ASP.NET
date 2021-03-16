using System;

namespace ArrayOfStringAndIntegerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            names[0] = "Arif";
            names[1] = "Emon";
          //  Console.WriteLine(names[0]);

            int[] numbersOfList = new int[10];
            int[] list = {10,20,30,40,50,60};
            numbersOfList[2] = 10;
            numbersOfList[3] = 20;
            Console.WriteLine(numbersOfList[3]);
            Console.WriteLine(list.Length);


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayValue = new int[6];
            arrayValue[0] = 1;
            arrayValue[1] = 2;
            arrayValue[2] = 3;
            arrayValue[3] = 4;
            arrayValue[4] = 5;
            arrayValue[5] = 6;
            foreach (var arrayItem in arrayValue)
            {
                Console.WriteLine(arrayItem);
            }
            Console.ReadLine();

        }
    }
}

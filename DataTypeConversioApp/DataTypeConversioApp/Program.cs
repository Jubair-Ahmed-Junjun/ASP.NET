using System;

namespace DataTypeConversioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            long l = 1000;
            //l = i;
            i = Convert.ToInt32(l);
            bool b = true;
            i = Convert.ToInt32(b);
            
            char c = 'A';
            string s = "AAA";
            i = c;
            //c = Convert.ToInt32(c);
            Console.WriteLine(c);
            Console.ReadKey();
           // Console.WriteLine("Hello World!");
        }
    }
}

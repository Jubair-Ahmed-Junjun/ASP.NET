using System;
using System.Collections;

namespace ArrayAndArray_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    int[] arrayList = new int[4];
                arrayList[0] = 1;
                arrayList[1] = 2;
                arrayList[2] = 4;
                arrayList[3] = 5;
                for(int i = 0;i<arrayList.Length;i++)
                {
                    Console.WriteLine(arrayList[i]);
                }
            */
           
            
            ArrayList myarrayList = new ArrayList();
            myarrayList.Add(123);
            myarrayList.Add("Jubair Ahmed");
            myarrayList.Add(2.312);
            myarrayList.Add('A');
            Console.WriteLine(myarrayList.Count);
            Console.WriteLine(myarrayList.Contains(123));
            foreach (var data in myarrayList )
            {
                Console.WriteLine(data);
            }
            myarrayList.Remove(123);
            Console.WriteLine(myarrayList.Count);
            foreach (var data in myarrayList)
            {
                Console.WriteLine(data);
            }
            myarrayList.RemoveAt(0);
            Console.WriteLine(myarrayList.Count);
            foreach (var data in myarrayList)
            {
                Console.WriteLine(data);
            }
            //myarrayList.RemoveRange();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList1App
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(10);
            myArrayList.Add("Junjun");
            myArrayList.Add(12.3);
            myArrayList.Add("AspDotNet");
            myArrayList.Add(100);
            foreach (var arrayListItem in myArrayList)
            {
                Console.WriteLine(arrayListItem);
            }
            Console.WriteLine(myArrayList.Count);
            myArrayList.Remove(12.3);
            foreach (var arrayListItem in myArrayList)
            {
                Console.WriteLine(arrayListItem);
            }
            Console.WriteLine("After remove eliment : "+myArrayList.Count);
            myArrayList.RemoveAt(0);
            foreach (var arrayListItem in myArrayList)
            {
                Console.WriteLine(arrayListItem);
            }
            Console.WriteLine("After use removeat function size will be : " + myArrayList.Count);

            myArrayList.RemoveRange(0,1);
            
            foreach (var arrayListItem in myArrayList)
            {
                Console.WriteLine(arrayListItem);
            }
            Console.WriteLine("After use remove range size will be : " + myArrayList.Count);
            Console.ReadLine();


        }
    }
}

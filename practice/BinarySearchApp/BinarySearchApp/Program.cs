using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BinarySearchApp
{
    class Program
    {
      public static void Main(string[] args)
        {
            //int[] arr = { 2, 3, 4, 10, 40 };
            int first, last, Middle, step = 0;
            Console.Write("Enter the array size for element :");
            int N1 = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[7];
            int i;
            Console.Write("Input Array elements:\n");
            for (i = 0; i <arr.Length; i++)
            {
                Console.Write("index - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Elements in array are: "+"\n");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.ReadLine();
            Console.WriteLine("Sorted Array :" );
            Array.Sort(arr);
            foreach (var items in arr)
            {
                Console.WriteLine(items);
            }           
            Console.Write("\n");

            int n = arr.Length;
            Console.WriteLine("Enter the query Value");
            int x = Convert.ToInt32(Console.ReadLine());
            int result = BinarySearch(arr, 0, n - 1, x);
            if (result == -1)
                Console.WriteLine("Not found");
            else
                Console.WriteLine("Find Index Value :" + result);
          

            first = 0;
            last = arr.Length - 1;
            Middle = (first + last) / 2;
            while (first <= last)
            {
                Console.WriteLine("For step:" + (step + 1));
                Console.WriteLine("First Index is : "+ arr[first]+"\n"+"Last index is :"+ arr[last]+ "\n"+"Middle index is :"+ arr[Middle]);
                if (arr[Middle] <x)
                {
                    Console.WriteLine(arr[Middle] +"less than :" + x);
                    first = Middle + 1;
                    step++;
                    Console.WriteLine("Need move to the RIGHT side\n");
                }
                else if (arr[Middle] == x)
                {
                    Console.WriteLine(arr[Middle]+ "="+ x);
                    Console.WriteLine(x +" is FOUND at position :"+ (Middle + 1));
                    step++;
                    break;
                }
                else
                {
                    Console.WriteLine(arr[Middle]+ "greater than :"+x);
                    last = Middle - 1;
                    step++;
                    Console.WriteLine("This  step will move to the LEFT side\n");
                }
                Console.WriteLine("Step completed :" +step);
                Middle = (first + last) / 2;
            }
            //if (first > last)
            //{
            //    Console.WriteLine(N1+ "is NOT in the list\n");
            //}
            Console.WriteLine("Total steps needed = :"+step);

            Console.ReadLine();
        }
          static int BinarySearch(int[] arr,int l,int r,int x)
        {
            if(r>=l)
            {
                
                int mid = l + (r - l) / 2;
                if (arr[mid] == x)
                    return mid;
                if (arr[mid] > x)
                    return BinarySearch(arr, l, mid - 1, x);
                else
                    return BinarySearch(arr, mid + 1, r, x);
            }
            return -1; 
        }
    }
}

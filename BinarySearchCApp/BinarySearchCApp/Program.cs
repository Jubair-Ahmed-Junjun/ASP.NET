using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchCApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, j, a, F, L, M, N1,  step = 0;
            int[] arr = new int[10];
            Console.WriteLine("Number of integers:");
            N = Convert.ToInt32(Console.ReadLine());                                     
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Enter the value to find: ");
            N1 = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < N; ++i)
            {
                for (j = i + 1; j < N; ++j)
                {
                    if (arr[i] > arr[j])
                    {
                        a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;
                    }
                }
            }
            Console.WriteLine("The Accending numbers are : ");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("\n");
            F = 0;
            L = N - 1;
            M = (F + L) / 2;
            while (F <= L)
            {
                Console.WriteLine("For step :"+step + 1);
                Console.WriteLine("First Number is:"+ arr[F]+ "\n"+"Last Number is:"+ arr[L]+"\n"+"Middle Number is: "+arr[M]);
                if (arr[M] < N1)
                {
                    Console.WriteLine("Here " + arr[M]+ "is smaller than"+ N1 + "\n");
                    F = M + 1;
                    step++;
                    Console.WriteLine("So, the step will move to the RIGHT side\n");
                }
                else if (arr[M] == N1)
                {
                    Console.WriteLine("Here "+ arr[M]+" is equal to "+ N1);
                    Console.WriteLine("So, "+ N1 +"is FOUND at position:"+ M + 1);
                    step++;
                    break;
                }
                else
                {
                    Console.WriteLine("Here "+ arr[M]+" is greater than :"+ N1);
                    L = M - 1;
                    step++;
                    Console.WriteLine("So, the step will move to the LEFT side\n");
                }
                Console.WriteLine("Step"+ step+ "completed.");
                M = (F + L) / 2;
            }
            if (F > L)
            {
                Console.WriteLine(N1+"is NOT in the list"+"\n");
            }
            Console.WriteLine("Total steps needed:"+ step);
            Console.ReadLine();
        }
        
    }
}

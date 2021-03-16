using System;

namespace FouthProblemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSquareSum = 0;
            int tolalSum = 0;            
            int dif = 0;
            for (int i = 1; i <= 100; i++)
            {
                totalSquareSum = totalSquareSum + (i * i);
                tolalSum = tolalSum + i;              
                //int sums = sum * sum;
                //dif = sums - sum;              
            }
            tolalSum = tolalSum * tolalSum;
            dif = tolalSum - totalSquareSum;
            Console.WriteLine("The sum : " + dif);
            Console.ReadLine();
        }
    }
}

using System;
using System 

namespace MethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            Console.Write("Enter first Number : ");           
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine()); 
            int sum = Add(firstNumber, secondNumber);
            Console.Write("The total sum is : " +""+sum);
            Console.ReadKey();
        }
        static int Add(int firstNumber,int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
    }
}

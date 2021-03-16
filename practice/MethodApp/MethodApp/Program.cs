using System;

namespace MethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber,secondNumber;
            ShowMessage();
            Console.Write("Enter First Number :");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number :");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            int add = AddNumber(firstNumber, secondNumber);
            Console.WriteLine("The Total Sum is :  "+add);
            Console.ReadLine();
        }
        static void ShowMessage()
        {
            Console.WriteLine("Hello World..!");
        }
        static int AddNumber(int firstNumber,int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }
        
    }
}

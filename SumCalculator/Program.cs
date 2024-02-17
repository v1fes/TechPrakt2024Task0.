using System;
namespace SumCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine(); 
            int number1 = Convert.ToInt32(input1); 

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2); 

            int sum = number1 + number2; 

            Console.WriteLine($"{number1} + {number2} = {sum}");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        while (true)
        {
            Console.Write("Enter a non-negative integer to compute its factorial: ");
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out number) && number >= 0)
            {
                long factorial = 1;
                for (int i = 2; i <= number; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"{number}! = {factorial}");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }
        }
    }
}
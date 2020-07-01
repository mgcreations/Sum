using System;
using System.Transactions;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            const int QUIT = 999;
            int num1;
            int num2;
            int sum;
            string inputString;

            Console.Write("Enter a number from 0 to 998: ");
            inputString = Console.ReadLine();

            num1 = Convert.ToInt32(inputString);

            while(num1 < 999)
            {
                Console.WriteLine("Enter another number between 0 and 998: ");
                inputString = Console.ReadLine();

                num2 = Convert.ToInt32(inputString);

                sum = num1 + num2;

                Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);

                Console.WriteLine("Enter a number from 0 to 998: ");
                inputString = Console.ReadLine();

                num1 = Convert.ToInt32(inputString);
            }

            Console.WriteLine("Have a nice day!");
        }
    }
}

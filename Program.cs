using System;

namespace TransFeeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var feeCalculator = new TransFeeCalculator();
                var input = 0;

                Console.WriteLine("Enter amount to be transfered:\n");

                if (int.TryParse(Console.ReadLine(), out input))
                    Console.WriteLine("\nAmount charged:\t{0}\n", feeCalculator.CalculateFee(input));
                else 
                {
                    Console.WriteLine("Invalid input");
                    break;
                }
            }

            Console.WriteLine("\nPress \'ctrl + c\' to exit");
            Console.ReadLine();
        }
    }
}

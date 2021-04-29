using System;

namespace Excercise_37_38
{
    class Program
    {
        static void Main(string[] args)
        
        {
            //Prompt the user to enter 5 numbers. Store these numbers in an array and output their sum.

            int i, n, sum = 0;
            bool toContinue = true;

            Console.WriteLine("Please enter 5 numbers to calculate their sum.\n ");

            do
            {

                Console.WriteLine("Input 5 numbers :");
                for (i = 1; i <= 5; i++)
                {
                    Console.Write("Number {0} :", i);

                    n = Convert.ToInt32(Console.ReadLine());
                    sum += n;
                }

                Console.WriteLine("The sum of your numbers is : {0}", sum);
                Console.WriteLine("Would you like to continue?  y|n ");

                string input = Console.ReadLine();
                if (input == "y")
                {
                    toContinue = true;
                }
                else
                {
                    toContinue = false;
                }
            }
            while (toContinue == true);
            //Prompt the user to enter 5 numbers. Store these numbers in an array and output their average.

            double i2, n2, sum2 = 0;
            double avg;

            do
            {
                Console.WriteLine("Please enter 5 numbers to calculate their average.\n ");

                Console.WriteLine("Input 5 numbers :");
                for (i2 = 1; i2 <= 5; i2++)
                {
                    Console.Write("Number {0} :", i2);

                    n2 = Convert.ToInt32(Console.ReadLine());
                    sum2 += n2;
                }
                avg = sum2 / 5;
                Console.WriteLine("The average of your number is : {0}", avg);

                Console.WriteLine("Would you like to continue?  y|n ");

                string input = Console.ReadLine();
                if (input == "y")
                {
                    toContinue = true;
                }
                else
                {
                    toContinue = false;
                }
            }
            while (toContinue == true);
        }             
    }
}

using System;

namespace Workshop_1_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;
            Console.WriteLine("Even Numbers :");
            for (number = 1; number<=100; number++)
            {
                if (number % 2 == 0)
                {                   
                    Console.Write(number + " ");
                    sum = sum + number;                   
                }
            }
            Console.WriteLine($"\nThe sum of all even numbers are {sum}");

        }
    }
}

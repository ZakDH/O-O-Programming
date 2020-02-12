using System;
using System.Collections.Generic;
using System.Linq;

namespace Workshop_1_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = ("School of Computer Science");
            string trim = s1.Replace(" ", "");
            Console.WriteLine(trim);
            int count = trim.Length;
            Console.WriteLine(count);
            Console.WriteLine("\n");

            IEnumerable<int> squares = Enumerable.Range(1, 10);
            foreach (int num in squares)
            {
                Console.WriteLine(num);

            }

            
        }
    }
}

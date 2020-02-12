using System;

namespace Workshop_1_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string greeting1 = "Hello";
            string greeting2 = "World";
            Console.WriteLine(greeting1+greeting2);
            int number = 5;
            int another = 10;
            Console.WriteLine($"Learning C#, we put {number} and {greeting2}");
            Console.WriteLine("Variables in output: {0}", number);
            Console.WriteLine("Variables in output: {0}, {1}", number, another);
            Console.WriteLine("To be or not to be");
            string s1 = "To be or not to be";
            string s2 = "be";
            string s3 = "and";
            Console.WriteLine(s1.Contains(s2));
            Console.WriteLine(s1.Contains(s3));
            

           
        }
    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please enter C or F: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Input = {input}");            
            
            temperatureConverter tc = new temperatureConverter();
            Console.WriteLine($"Celcius = {temperatureConverter.C} Farenheit = {temperatureConverter.F}");
            Console.WriteLine($"F = {temperatureConverter.F}, C = {FtoC}");
            Console.WriteLine($"C = {temperatureConverter.C}, F = {CtoF}");
        }
    }
    class temperatureConverter
    {
        public static double C = 0;
        public static double F = 32;
        public double CtoF = (temperatureConverter.C * 9.0 / 5.0) + 32;
        public double FtoC = (32 - temperatureConverter.F) * (5.0 / 9.0);

    }
}

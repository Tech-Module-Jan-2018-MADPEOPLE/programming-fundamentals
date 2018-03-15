using System;

namespace MilesToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{double.Parse(Console.ReadLine()) * 1.60934:f2}");
        }
    }
}

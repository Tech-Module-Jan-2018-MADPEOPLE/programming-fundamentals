// CONFIRMED from <MladenRaykov>


using System;

namespace MilesToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            // parse the miles to double number
            double miles = double.Parse(Console.ReadLine());

            //convert miles to kilometers
            double kilometers = miles * 1.60934;

            //round to the second digit after the decimal point
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}

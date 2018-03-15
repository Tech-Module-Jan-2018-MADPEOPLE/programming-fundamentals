using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve two lines from the Console width 
            //and height -> a double type
            double width = double.Parse(Console.ReadLine());
            double height= double.Parse(Console.ReadLine());

            //We are calculating the rectangle area and printing the result
            Console.WriteLine($"{width * height:F2}");
        }
    }
}

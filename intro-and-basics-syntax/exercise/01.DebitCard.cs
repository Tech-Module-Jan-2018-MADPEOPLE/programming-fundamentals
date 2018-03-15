using System;

namespace DebitCardNum
{
    class Program
    {
        static void Main(string[] args)
        {
		//We receive from the Console four numbers
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
		
		//TODO
            Console.WriteLine($"{num1:d4} {num2:d4} {num3:d4} {num4:d4}");
        }
    }
}

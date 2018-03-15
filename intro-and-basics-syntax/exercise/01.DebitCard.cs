//CONFIRMED from <AntoniaShalamanova>
using System;

namespace DebitCardNum
{
    class Program
    {
        static void Main(string[] args)
        {
		//We receive from the Console four numbers
        // Changed variables name from num -> number
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
		
		//TODO
            Console.WriteLine($"{number1:d4} {number2:d4} {number3:d4} {number4:d4}");
        }
    }
}

//Confirmed from <mustafa_q1>

using System;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve from the Console the product name -> a string
            string nameString = Console.ReadLine();

            /*In the next three lines, we recieve the volume,
             * energy and sugar content of our product,
             * as an integer
             */
            int volume = int.Parse(Console.ReadLine());
            double energyPerHundredMl = double.Parse(Console.ReadLine());
            double sugarPerHundredMl = double.Parse(Console.ReadLine());
            
            //We calculate
            double energyPerDrink = (energyPerHundredMl * volume)/100;
            double sugarPerDrink = (sugarPerHundredMl * volume)/100;

            //TODO
            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", energyPerDrink, sugarPerDrink);
        }
    }
}


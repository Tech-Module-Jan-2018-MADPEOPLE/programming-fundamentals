using System;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double energyPerHundredMl = double.Parse(Console.ReadLine());
            double sugarPerHundredMl = double.Parse(Console.ReadLine());

            double energyPerDrink = (energyPerHundredMl * volume)/100;
            double sugarPerDrink = (sugarPerHundredMl * volume)/100;

            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", energyPerDrink, sugarPerDrink);

            //Console.WriteLine($"{volume}ml {name}:\r\n{energyPerDrink}kcal, {sugarPerDrink}g sugars");

        }
    }
}

/*
Nuke-Cola
220
300
70

*/
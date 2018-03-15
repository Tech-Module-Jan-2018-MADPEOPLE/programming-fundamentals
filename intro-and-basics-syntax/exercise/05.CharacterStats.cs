using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats05
{
    class Program
    {
        static void Main(string[] args)
        {
            // input data from console
            // for test
            string characterName = Console.ReadLine();
            int currentCharacterHealth = int.Parse(Console.ReadLine());
            int maxCharacterHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());


            // write result on console
            // edit for test
            // new comment
            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine("Health: |{0}{1}|", new string('|', currentCharacterHealth), new string('.', maxCharacterHealth - currentCharacterHealth));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', currentEnergy), new string('.', maxEnergy - currentEnergy));


        }
    }
}

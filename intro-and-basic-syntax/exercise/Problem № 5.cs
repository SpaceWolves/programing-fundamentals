using System;

namespace Problem__5
{
    class Program
    {
        static void Main(string[] args)
        {
			// Reading the input from the console.
            string namePlayer = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

			//Calculating and printing the result in a conditional format. 
            Console.WriteLine($"Name: {namePlayer}");
            Console.WriteLine($"Health: |{new string('|', currentHealth)}{new string('.', maxHealth - currentHealth)}|");
            Console.WriteLine($"Energy: |{new string('|', currentEnergy)}{new string('.', maxEnergy - currentEnergy)}|");
            
        }
    }
}

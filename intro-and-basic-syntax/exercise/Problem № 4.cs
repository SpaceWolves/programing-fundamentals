using System;

namespace Problem___4.cs
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int volumeInMililiters = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double totalEnergy = (double)(volumeInMililiters * energyContent) / 100;
            double totalSugar = (double)(volumeInMililiters * sugarContent) / 100;

            Console.WriteLine($"{volumeInMililiters}ml {productName}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}

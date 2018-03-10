cousing System;

namespace Problem___4.cs
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            //hello ...documented
            string productName = Console.ReadLine();
            int volumeInMililiters = int.Parse(Console.ReadLine());
            int energyContentPer100ml = int.Parse(Console.ReadLine());
            int sugarContentPer100ml = int.Parse(Console.ReadLine());

            double totalEnergy = (double)(volumeInMililiters * energyContentPer100ml) / 100;
            double totalSugar = (double)(volumeInMililiters * sugarContentPer100ml) / 100;
 
            Console.WriteLine($"{volumeInMililiters}ml {productName}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}

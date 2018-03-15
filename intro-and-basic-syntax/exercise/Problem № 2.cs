using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());//Getting the width
            var height = double.Parse(Console.ReadLine());//Getting the height
            var area = (width * height);//Calculating the area
            Console.WriteLine("{0:f2}", area);//Printing the area
        }
    }
}

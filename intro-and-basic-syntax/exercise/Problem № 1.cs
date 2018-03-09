using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{int.Parse(Console.ReadLine()):d4} {int.Parse(Console.ReadLine()):d4} {int.Parse(Console.ReadLine()):d4} {int.Parse(Console.ReadLine()):d4}");
        }
    }
}
//CONFIRMED from <CvetaCapova>
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   //In one line we receive four integers. 
            //In the same line we print them.
            //If the integers are with less than 4 digits, we add zeroes until they represent four digit numbers.
            Console.WriteLine($"{int.Parse(Console.ReadLine()):d4} {int.Parse(Console.ReadLine()):d4} {int.Parse(Console.ReadLine()):d4} {int.Parse(Console.ReadLine()):d4}");
        }
    }
}
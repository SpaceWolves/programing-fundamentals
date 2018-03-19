using System;
using System.Linq;

class MultidimentionalArrays
{
    static void Main()
    {
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        int rows = size[0];
        int columns = size[1];

        string[,] result = new string[rows, columns];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                char rowChar = alphabet[row];
                char colChar = alphabet[col + row];
                result[row, col] = string.Format($"{rowChar}{colChar}{rowChar}");
            }
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Console.Write($"{result[row, col]} ");
            }
            Console.WriteLine();
        }
    }
}
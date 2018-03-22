using System;
using System.Linq;

class MultidimentionalArrays
{
    static void Main()
    {
        //Reading size from the Console
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        //Getting the count of rows and columns
        int rows = size[0];
        int columns = size[1];

        string[,] result = new string[rows, columns];

        //Filling the result array
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                //Adding new variables
                char rowChar = alphabet[row];
                char colChar = alphabet[col + row];
                result[row, col] = string.Format($"{rowChar}{colChar}{rowChar}");
            }
        }

        //Printing the result array in several rows
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
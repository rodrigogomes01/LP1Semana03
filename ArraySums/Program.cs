using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Ask for the horizontal dimension for the array
            Console.Write("Enter the horizontal dimension of the array");
            string HorizontalDimension = Console.ReadLine();
            int hor_val = char.Parse(HorizontalDimension);
            ///Ask for the vertical dimension for the array
            Console.Write("Enter the vertical dimension of the array");
            string verticalDimension = Console.ReadLine();
            int ver_val = char.Parse(verticalQuestion);

            float[,] array = new float[HorizontalDimension, verticalDimension];

            ///Ask for number in i and j
            for (int i = 0; i < hor_val; i++)
            {
                for (int j = 0; j < ver_val; j++)
                {
                    Console.Write($"Ask for a number in this array [{i},{j}]: ");
                    array[i, j] = float.Parse(Console.ReadLine());
                }
            }

        }
    }
}
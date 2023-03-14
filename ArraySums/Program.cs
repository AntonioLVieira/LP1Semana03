using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the horizontal dimension of the array: ");
            int horizontal = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the vertical dimension of the array: ");
            int vertical = int.Parse(Console.ReadLine());
            float [][] array = new float [horizontal][vertical];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine("Insert a real number for the position ij of the array: ");
                    array[i][j] = float.Parse(Console.ReadLine());
                }
            }
        }
    }
}

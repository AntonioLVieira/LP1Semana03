using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the horizontal and vertical dimension of the array: ");
            int count = 1;
            int count_line = 0;
            int count_column = 0;
            int dimension = int.Parse(Console.ReadLine());
            float [,] array = new float [dimension,dimension];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Insert a real number for the position " + count + " of the array: ");
                    array[i,j] = float.Parse(Console.ReadLine());
                    count++;
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                float line_sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    line_sum += array[i,j];
                }
                count_line++;
                Console.WriteLine("The sum of the line " +  count_line + " is: " + line_sum);
            }
            for (int j = 0; j < array.GetLength(1); j++)
            {
                float column_sum = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    column_sum += array[i,j];
                }
                count_column++;
                Console.WriteLine("The sum of the column " +  count_column + " is: " + column_sum);
            }
        }
    }    
}

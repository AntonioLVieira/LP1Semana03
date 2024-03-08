using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string i in args)
            {
                if (i.Length > 6)
                {
                    Console.WriteLine($"Argumento demasiado grande: {i}");
                    return;
                }

                if (i.Length > 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
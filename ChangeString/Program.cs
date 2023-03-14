using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Say something: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Insert a character: ");
            char character = char.Parse(Console.ReadLine());
            for (int i = 0; i < sentence.Length; i++)
            {
                if (character != sentence[i])
                {
                    Console.Write(sentence[i]);
                }
            }
        }
    }
}

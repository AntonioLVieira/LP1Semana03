using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string frase = Console.ReadLine();
            
            Console.Write("Caráter: ");
            char character = char.Parse(Console.ReadLine());

            string changedString = ReplaceCharacter(frase, character);

            Console.WriteLine("Modified String: " + changedString);
        }

        static string ReplaceCharacter(string input, char replacement)
        {
            char[] characters = input.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == replacement)
                {
                    characters[i] = 'X';
                }
            }

            return new string(characters);
        }
    }
}

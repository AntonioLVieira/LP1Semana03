using System;

namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Players do you wwant to have?");
            int n = int.Parse(Console.ReadLine());
            int Player_Count = 1;
            int Power_Count = 1;


            //Cria uma array com o tamanho n
            int [] array = new int [n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("How many powers does the Player " + Player_Count + " have?");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("Which is the power " + Power_Count + " of the Player ");
                string Player_Powers = Console.ReadLine();
                Player_Count++;
                Power_Count++;
            }
        }
    }
}

using System;

namespace HeroPerks
{

        [Flags]
    enum Perks
    {
        None = 0,
        WaterBreathing = 1,
        Stealth = 2,
        AutoHeal = 4,
        DoubleJump = 8
    }
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("You dont't have perks!");
                return;
            }

            Perks playerPerks = 0;

            foreach (char perkChar in args[0])
            {
                switch (perkChar)
                {
                    case 'w':
                        playerPerks ^= Perks.WaterBreathing;
                        break;
                    case 'a':
                        playerPerks ^= Perks.Stealth;
                        break;
                    case 's':
                        playerPerks ^= Perks.AutoHeal;
                        break;
                    case 'd':
                        playerPerks ^= Perks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("No Perks at all!");
                        return;
                }
            }

            Console.WriteLine($"Player perks: {playerPerks}");

            if ((playerPerks & (Perks.Stealth | Perks.DoubleJump)) == (Perks.Stealth | Perks.DoubleJump))
            {
                Console.WriteLine("Silent jumper!");
            }

            if ((playerPerks & Perks.AutoHeal) == 0)
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}
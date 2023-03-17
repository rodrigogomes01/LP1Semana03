using System;
namespace PlayerPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks P1Perks = 0;

            // Check every character on the first argument gave
            foreach (char c in args[0])
            {

                // Add a perk depending on the user's input
                if (c == 'w')
                {
                    P1Perks ^= Perks.WaterBreathing;
                }
                if (c == 's')
                {
                    P1Perks ^= Perks.Stealth;
                }
                if (c == 'a')
                {
                    P1Perks ^= Perks.AutoHealing;
                }
                if (c == 'd')
                {
                    P1Perks ^= Perks.DoubleJump;
                }
            }

            Console.WriteLine(P1Perks);
        }
    }
}

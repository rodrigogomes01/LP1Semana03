using System;
namespace PlayerPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks P1Perks = 0;
            bool PerkNotValid = false;

            // Check every character on the first argument gave
            foreach (char c in args[0])
            {
                // Add a perk depending on the user's input
                if (c == 'w')
                {
                    P1Perks ^= Perks.WaterBreathing;
                }
                else if (c == 's')
                {
                    P1Perks ^= Perks.Stealth;
                }
                else if (c == 'a')
                {
                    P1Perks ^= Perks.AutoHealing;
                }
                else if (c == 'd')
                {
                    P1Perks ^= Perks.DoubleJump;
                }

                else
                {
                    PerkNotValid = true;
                }
            }

            Console.WriteLine(P1Perks);

            ///Check the player's perks
            if (PerkNotValid)
            {
                Console.WriteLine("Perk Unknown");
            }
            else
            {
                Console.WriteLine(P1Perks);
            }
        }
    }
}
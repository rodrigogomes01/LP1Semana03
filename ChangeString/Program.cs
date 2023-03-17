using System;
namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a string");
            string AskString = Console.ReadLine();

            Console.Write("Give me  a character");
            string AskCharacter = Console.ReadLine();
            char Character = char.Parse(AskCharacter);

            ///Print the string omitting the character
            foreach (char c in AskString) 
            {
                if (c != Character)
                {
                    Console.Write(c);
                }
            }
        }
    }
}
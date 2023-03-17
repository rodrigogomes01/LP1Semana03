using System;
namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a character");
            string AskCharacter = Console.ReadLine();
            char Character = char.Parse(AskCharacter);
        }
    }
}
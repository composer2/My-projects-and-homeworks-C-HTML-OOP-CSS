using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPasswordGenerator
{
    class RandomPasswordGenerator
    {
        private const string CapitalLetters= "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private const string SmallLetters= "abcdefghijklmnopqrstuvwxyz";

        private const string Digits = "0123456789";

        private const string SpecialChars= "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";

        private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialChars;

        private static Random rand = new Random();

        static void Main(string[] args)
        {
            StringBuilder pass = new StringBuilder();
            // Generate two random capital letters
            for (int i = 1; i <= 2; i++)
            {
                char capitalLetters = GenerateChar(CapitalLetters);
                InsertAtRandomPosition(pass, capitalLetters);
            }
            // Generate two random small letters
            for (int i = 1; i <= 2; i++)
            {
                char smallLetter = GenerateChar(SmallLetters);
                InsertAtRandomPosition(pass, smallLetter);
            }
            // Generate one random digit
            char digit = GenerateChar(Digits);
            InsertAtRandomPosition(pass, digit);
            // Generate 3 special characters
            for (int i = 1; i <= 3; i++)
            {
                char specialChar = GenerateChar(SpecialChars);
                InsertAtRandomPosition(pass, specialChar);
            }
            // Generate few random characters (between 0 and 7)
            int count = rand.Next(8);
            for (int i = 1; i < count; i++)
            {
                char specialChar = GenerateChar(AllChars);
                InsertAtRandomPosition(pass, specialChar);
            }
            Console.WriteLine(pass);
        }

        private static void InsertAtRandomPosition(StringBuilder pass, char characters)
        {
            int randomPos = rand.Next(pass.Length + 1);
            pass.Insert(randomPos, characters);
        }

        private static char GenerateChar(string availableChars)
        {
            int randomIndex = rand.Next(availableChars.Length);
            char randomChar = availableChars[randomIndex];
            return randomChar;
        }
    }
}

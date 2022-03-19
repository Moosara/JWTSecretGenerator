using System;
using System.Text;

namespace JWTSecretGenerator
{
    class Program
    {
        public static void Main(string[] args)
        {
            var characterPossibilities = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890-_.";

            // 1 Character is 8 bits
            // 32 Characters = 256 bits
            // 64 Characters =  512 bits (Recommended Minimum)
            // 128 Characters = 1024 bits
            var tokenCharacterLength = 128;

            StringBuilder jwtSecret = new StringBuilder();

            var randomNumberGenerator = new Random();

            while (jwtSecret.Length < tokenCharacterLength)
            {

                jwtSecret.Append(characterPossibilities[randomNumberGenerator.Next(0, characterPossibilities.Length - 1)]);

            }

            Console.WriteLine($"Character Length: {jwtSecret.Length}");
            Console.WriteLine($"Total bits: {jwtSecret.Length / 8}");
            Console.WriteLine($"Secret: {jwtSecret}");
            Console.WriteLine("\nPress any key to exit");
            Console.ReadLine();


        }
    }
}

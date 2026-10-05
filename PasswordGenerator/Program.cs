using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Password Generator";
            Console.Write("How many characters should the password contain?: ");
            string input = Console.ReadLine();

            Random random = new Random();

            if (!int.TryParse(input, out int length) || length < 6)
            {
                Console.WriteLine("The password must be at least 6 characters long.");
            }
            else
            {
                string characters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*_-+";

                string password = "";

                for (int i = 0; i < length; i++)
                {
                    int randomIndex = random.Next(characters.Length);

                    password = password + characters[randomIndex];
                }

                Console.WriteLine("Generated Password: " + password);
            }

            Console.WriteLine("\nPress any key to exit :)");
            Console.ReadKey();
        }
    }
}

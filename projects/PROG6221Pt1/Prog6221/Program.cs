
    using System;
    using System.Media;

namespace Prog6221
{
    class CyberChatBot
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Recording.PlayVoiceGreeting();
            
            Image.DisplayAsciiLogo();

            string userName = GetUserName();
            
            DisplayWelcomeMessage(userName);
            Response.ShowHelp(userName);
        }


        static string GetUserName()
        {
            Console.Write("\n Please enter your name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "User";
            }
            return name;
        }

        static void DisplayWelcomeMessage(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n Hello, {name}, I'm your Cybersecurity Awareness Bot.");
            Console.WriteLine("Ask me about passwords, phishing, or safe browsing. Type 'exit' to quit.");
            Console.ResetColor();
        }

    }
}
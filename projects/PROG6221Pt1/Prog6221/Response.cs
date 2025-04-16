using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog6221
{
    internal class Response
    {
        public static void ShowHelp(string name)
        {
            while (true)
            {
                Console.Write($"\n🤖 {name}, ask me a question: ");
                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("❓I didn't catch that. Can you rephrase?");
                    continue;
                }

                if (input.Contains("exit")) break;

                // Responses to user questions
                if (input.Contains("password🔑"))
                {
                    Console.WriteLine(" Tip: Use long, complex passwords and a password manager.");
                }
                else if (input.Contains("phishing🎣"))
                {
                    Console.WriteLine(" Beware of fake emails asking for your credentials or money.");
                }
                else if (input.Contains("safe browsing🦺"))
                {
                    Console.WriteLine(" Stay safe: Avoid clicking on suspicious links and keep your browser updated.");
                }
                else if (input.Contains("who are you? 😵‍💫") || input.Contains("purpose"))
                {
                    Console.WriteLine(" I'm here to help you learn about staying safe online!");
                }
                else
                {
                    Console.WriteLine(" Sorry, I didn't understand that. Can you try asking in a different way?");
                }
            }

            Console.WriteLine("\n Goodbye!🙋🏾‍♂️ Stay safe out there.");
        }
    }
}

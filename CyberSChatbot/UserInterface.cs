using System;
using System.IO;
using System.Threading;

namespace CybersecurityChatbot
{
    public class UI
    {
        // 🔹 1. SHOW ASCII HEADER (TOP)
        public void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            try
            {
                string path = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Images",
                    "ascii.txt"
                );

                string art = File.ReadAllText(path);

                Console.WriteLine("========================================");
                Console.WriteLine(art);
                Console.WriteLine("========================================");
            }
            catch
            {
                Console.WriteLine("=== CYBERSECURITY CHATBOT ===");
            }

            Console.ResetColor();
            Console.WriteLine();
        }

        // 🔹 2. GREETING MESSAGE (BELOW ASCII)
        public void ShowIntroMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            TypeText("Hello! Welcome to the Cybersecurity Awareness Chatbot.");
            TypeText("I'm here to help you stay safe online.");
            TypeText("You can ask me about:");
            TypeText("- Phishing scams");
            TypeText("- Password security");
            TypeText("- Safe browsing");
            TypeText("\nType 'exit' anytime to close the chatbot.\n");

            Console.ResetColor();
        }

        // 🔹 3. GET NAME
        public string GetName()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
                name = "User";

            return name;
        }

        // 🔹 4. USER INPUT (CHAT AREA)
        public string GetInput(string name)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{name}: ");
            return Console.ReadLine();
        }

        // 🔹 5. BOT RESPONSE
        public void ShowResponse(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            TypeText(message);
            Console.WriteLine();
            Console.ResetColor();
        }

        // 🔹 Typing effect
        private void TypeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(15);
            }
            Console.WriteLine();
        }
    }
}
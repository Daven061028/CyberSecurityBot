using System;

namespace CybersecurityChatbot
{
    public class Chatbot
    {
        private UI ui = new UI();
        private Audio audio = new Audio();
        private Responses responses = new Responses();

        public void Run()
        {
            // 1. Show ASCII
            ui.ShowHeader();

            // 2. Play audio
            audio.Play();

            // 3. Show greeting message (TEXT VERSION)
            ui.ShowIntroMessage();

            // 4. Ask for name
            string name = ui.GetName();

            // 5. Start chat
            while (true)
            {
                string input = ui.GetInput(name);

                // EXIT OPTION
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("\nGoodbye! Stay safe online 👋");
                    break;
                }

                string reply = responses.GetReply(input, name);
                ui.ShowResponse(reply);
            }
        }
    }
}
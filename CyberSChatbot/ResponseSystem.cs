namespace CybersecurityChatbot
{
    public class Responses
    {
        public string GetReply(string input, string name)
        {
            if (string.IsNullOrWhiteSpace(input))
                return $"I didn’t catch that, {name}. Try asking about phishing or passwords.";

            input = input.ToLower();

            if (input.Contains("hello"))
                return $"Hello {name}! How can I help you today?";

            if (input.Contains("how are you"))
                return $"I'm great, {name}! Ready to keep you safe online.";

            if (input.Contains("phishing"))
                return $"{name}, phishing is a scam where attackers trick you into giving personal info. Never click suspicious links.";

            if (input.Contains("password"))
                return $"{name}, use strong passwords with numbers, symbols, and avoid reusing them.";

            if (input.Contains("safe browsing"))
                return $"{name}, always check for HTTPS and avoid unknown websites.";

            if (input.Contains("malware"))
                return $"{name}, malware can damage your device. Keep your software updated.";

            if (input.Contains("purpose"))
                return $"My purpose is to educate South Africans about cybersecurity threats.";

            return $"Sorry {name}, I don’t understand that yet. Try asking about phishing or passwords.";
        }
    }
}
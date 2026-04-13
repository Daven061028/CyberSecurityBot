using System;
using System.IO;
using System.Media;

namespace CybersecurityChatbot
{
    public class Audio
    {
        public void Play()
        {
            try
            {
                string path = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Audio",
                    "greeting.wav"
                );

                SoundPlayer player = new SoundPlayer(path);
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Audio not found.");
            }
        }
    }
}
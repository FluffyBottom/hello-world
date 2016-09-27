using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace ConsoleApplication2
{
    class Program
    {
        static string[] lyrics = { "Just a small town girl",
                                   "Livin' in a lonley world",
                                   "She took the midnight train",
                                   "Goin' anywhere",
                                   "Just a city boy",
                                   "Born and raised in South Detroit",
                                   "He took the midnight train",
                                   "Goin' anywhere",
                                   "A singer in a smokey room",
                                   "The smell of wine and cheap perfume",
                                   "For a smile they share the night",
                                   "It goes on and on, and on, and on",
                                   ", and on, and on",
                                   ", and on, and on",
                                   ", and on, and on",
                                   ", and on, and on",
                                   ", and on, and on",
                                   ", and on, and on",
                                   ", and on, and on" };

        static void Main(string[] args)
        {
            SpeechSynthesizer speaker = new SpeechSynthesizer();
            speaker.Rate = 1;
            speaker.Volume = 100;
            for (int i = 0; i < lyrics.Length; ++i)
            {
                speaker.Speak(lyrics[i]);
            }

            foreach(var a in speaker.GetInstalledVoices())
            {
                System.Console.WriteLine(a.VoiceInfo.Name);
            }

            System.Console.ReadKey();
        }
    }
}

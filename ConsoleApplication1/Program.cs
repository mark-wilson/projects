using System;
using System.Speech.Synthesis;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
                        
            Console.WriteLine("Who are you?");
            synth.Speak("Who are you?");

            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);
            synth.Speak("Hello " + name);
            
            Console.WriteLine("How much sleep did you have last night?");
            synth.Speak("How much sleep did you have last night?");
            
            int hoursOfSleep = int.Parse(Console.ReadLine());
            if (hoursOfSleep < 8)
            {
                Console.WriteLine("You must be tired!");
                synth.Speak("You must be tired!");
            }
            else
            {
                Console.WriteLine("You seem well rested.");
                synth.Speak("You seem well rested.");
            }
        }
    }
}
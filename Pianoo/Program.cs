using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pianoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press a number key (1–8) to play a note from C to C:");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(intercept: true);
                char ch = key.KeyChar;
                Piano(ch);
            }
        }


        static void Piano(char ch)
        {
            int duration = 300;

            if (ch == '1')
            {
                Console.Beep(261, duration); // C4
            }
            if (ch == '2')
            {
                Console.Beep(293, duration); // D
            }
            if (ch == '3')
            {
                Console.Beep(329, duration); // E
            }
            if (ch == '4')
            {
                Console.Beep(349, duration); // F
            }
            if (ch == '5')
            {
                Console.Beep(392, duration); // G
            }
            if (ch == '6')
            {
                Console.Beep(440, duration); // A
            }
            if (ch == '7')
            {
                Console.Beep(493, duration); // B
            }
            if (ch == '8')
            {
                Console.Beep(523, duration); // C5 (one octave higher)
            }
        }
    }
}

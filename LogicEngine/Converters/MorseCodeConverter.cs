using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicEngine.Converters
{
    public static class MorseCodeConverter
    {
        private static readonly Dictionary<char, string> MorseTable = new()
        {
            // Buchstaben A–Z
            ['A'] = ".-",
            ['B'] = "-...",
            ['C'] = "-.-.",
            ['D'] = "-..",
            ['E'] = ".",
            ['F'] = "..-.",
            ['G'] = "--.",
            ['H'] = "....",
            ['I'] = "..",
            ['J'] = ".---",
            ['K'] = "-.-",
            ['L'] = ".-..",
            ['M'] = "--",
            ['N'] = "-.",
            ['O'] = "---",
            ['P'] = ".--.",
            ['Q'] = "--.-",
            ['R'] = ".-.",
            ['S'] = "...",
            ['T'] = "-",
            ['U'] = "..-",
            ['V'] = "...-",
            ['W'] = ".--",
            ['X'] = "-..-",
            ['Y'] = "-.--",
            ['Z'] = "--..",

            // Ziffern 0–9
            ['0'] = "-----",
            ['1'] = ".----",
            ['2'] = "..---",
            ['3'] = "...--",
            ['4'] = "....-",
            ['5'] = ".....",
            ['6'] = "-....",
            ['7'] = "--...",
            ['8'] = "---..",
            ['9'] = "----.",

            // Sonderzeichen (optional)
            ['.'] = ".-.-.-",
            [','] = "--..--",
            ['?'] = "..--..",
            ['!'] = "-.-.--",
            ['-'] = "-....-",
            ['/'] = "-..-.",
            ['('] = "-.--.",
            [')'] = "-.--.-",
            ['='] = "-...-",
            ['+'] = ".-.-.",
            ['@'] = ".--.-.",
            [':'] = "---..."
        };

        public static string ToMorse(string text)
        {
            return string.Join(" ", text.ToUpper().Where(MorseTable.ContainsKey).Select(c => MorseTable[c]));
        }

        public static string FromMorse(string morse)
        {
            var inverse = MorseTable.ToDictionary(kv => kv.Value, kv => kv.Key);
            return string.Concat(morse.Split(' ').Select(m => inverse.GetValueOrDefault(m, '?')));
        }
    }
}

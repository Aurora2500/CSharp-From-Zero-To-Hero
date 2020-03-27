using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class MostCommonLetterFinder
    {
        public static char Find(string sentence)
        {
            if (string.IsNullOrEmpty(sentence) || string.IsNullOrWhiteSpace(sentence))
            {
                throw new ArgumentNullException();
            }
            var charDictionary = new Dictionary<char, int>();
            foreach (char symbol in sentence)
            {
                if (charDictionary.ContainsKey(symbol))
                {
                    charDictionary[symbol] += 1;
                }
                else
                {
                    charDictionary[symbol] = 1;
                }
            }

            char highestSymbol = char.MinValue;
            int highestFrequency = 0;

            foreach (KeyValuePair<char, int> pair in charDictionary)
            {
                char currentChar = pair.Key;
                int frecuency = pair.Value;

                if (frecuency > highestFrequency)
                {
                    highestSymbol = currentChar;
                    highestFrequency = frecuency;
                }
            }

            return highestSymbol;
        }
    }
}
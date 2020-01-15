using System;

namespace Task1
{
    /// <summary>
    /// Provides static methods strings.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Returns the vowels count contained in the input string.
        /// </summary>
        /// <param name="str">Input string.</param>
        /// <returns>Vovels count.</returns>
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str), "String cannot be null.");
            }

            if (str.Length == 0)
            {
                throw new ArgumentException("String cannot be empty.");
            }

            int vovelCounter = 0;
            char[] vovelSymbolsArray = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char[] strCharsArray = str.ToCharArray();
            for (int i = 0; i < vovelSymbolsArray.Length; i++)
            {
                for (int j = 0; j < strCharsArray.Length; j++)
                {
                    if (vovelSymbolsArray[i] == strCharsArray[j])
                    {
                        vovelCounter++;
                    }
                }
            }

            return vovelCounter;
        }
    }
}

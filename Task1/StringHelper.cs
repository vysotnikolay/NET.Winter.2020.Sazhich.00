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
        /// <exception cref="ArgumentNullException">Thrown when str equals null.</exception>
        /// <exception cref="ArgumentException">Thrown when str is String.Empty.</exception>
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
            string vovelSymbols = "aeiou";
            int strLength = str.Length; // оптимизация, чтобы длина строки не вычислялась на каждой итерации
            for (int i = 0; i < strLength; i++)
            {
                if (vovelSymbols.Contains(str[i], StringComparison.OrdinalIgnoreCase))
                {
                    vovelCounter++;
                }
            }

            return vovelCounter;
        }
    }
}

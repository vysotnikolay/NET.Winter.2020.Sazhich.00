using System;

namespace Task2
{
    /// <summary>
    /// Provide methods with integers.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Returns the GCD of two integers.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GSD value.</returns>
        /// <exception cref="ArgumentException">Thrown when two numbers are 0 at the same time. -or- Thrown when two numbers are 0 and int.MinValue at the same time.</exception>
        public static int GetGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if ((a == 0 && b == int.MinValue) || (b == 0 && a == int.MinValue))
            {
                throw new ArgumentException("0 and int.MinValue at the same time cannot be passed to the method, because the execution result will go beyond int.MaxValue");
            }

            if (b == 0)
            {
                return Math.Abs(a);
            }

            int tempB = a % b;
            return GetGcd(b, tempB);
        }
    }
}
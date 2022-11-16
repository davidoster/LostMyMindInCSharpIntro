using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_16_11_2022.Helpers
{
    internal class RandomGenerator
    {
        private static Random _random = new Random();

        public static int GenerateInteger(int maxValue)
        {
            return _random.Next(maxValue);
        }

        public static double GenerateDouble(int maxValue)
        {
            return _random.NextDouble() * maxValue;
        }

        public static string GenerateString(int noOfCharacters)
        {
            string result = "";
            for (int i = 0; i < noOfCharacters; i++)
            {
                result += Convert.ToChar(_random.Next(100));
            }
            return result;
        }
    }
}

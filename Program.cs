using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(c => Convert.ToInt32(c)).ToList();

            int result = birthdayCakeCandles(candles);
        }

        private static int birthdayCakeCandles(List<int> candles)
        {
            var result = candles.Where(x => x == (candles.Max())).Count();
            return result;
        }
    }
}

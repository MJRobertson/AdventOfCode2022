using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace adventofcode.source
{
    public static class Day1
    {
        //find out how many times it increases
        public static string Part1(string[] data)
        {
            int currentTotal = 0;
            int tempTotal = 0;
            foreach (var str in data)
            {
                if (string.IsNullOrWhiteSpace(str))
                {
                    tempTotal = 0;
                    continue;
                }

                if (int.TryParse(str, out int result)) tempTotal += result;
                if (tempTotal > currentTotal) currentTotal = tempTotal;
            }

            return currentTotal.ToString();
        }

        //sum for three measurements using letters to match
        public static string Part2(string[] data)
        {
            List<int> totals = new List<int>();
            int tempTotal = 0;
            foreach (var str in data)
            {
                if (string.IsNullOrWhiteSpace(str))
                {
                    totals.Add(tempTotal);
                    tempTotal = 0;
                    continue;
                }

                if (int.TryParse(str, out int result)) tempTotal += result;
            }

            if (tempTotal != 0) totals.Add(tempTotal);

            totals.Sort();
            totals.Reverse();
            return totals.ToArray()[0..3].Sum().ToString();
        }

    }
}

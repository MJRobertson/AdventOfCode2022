using System.Data.Common;
using System.Text.RegularExpressions;
namespace adventofcode.source
{
    public static class Day5
    {
        public static string Part1(string[] data)
        {
            Stack<char>[] storage = new Stack<char>[9];

            for (int y = 7; y >= 0; --y)
            {
                for (int x = 1, j = 0; x < 36; x += 4, j++)
                {
                    if (storage[j] == null) storage[j] = new Stack<char>();

                    char c = data[y][x];
                    if (char.IsWhiteSpace(c)) continue;
                    storage[j].Push(c);
                }
            }

            for (int i = 10; i < data.Count(); ++i)
            {
                var split = Regex.Matches(data[i], @"\d+").OfType<Match>().Select(m => m.Value).ToArray();// Regex.Match(data[i], "/[0-9]+/g");
                var parse = split.Select(x => int.Parse(x.ToString())).ToArray();
                int[] directions = parse;
                for (int m = 0; m < directions[0]; ++m)
                {
                    storage[directions[2] - 1].Push(storage[directions[1] - 1].Pop());
                }
            }

            string output = "";
            foreach (var s in storage)
            {
                output += s.Pop();
            }

            return output;
        }

        public static string Part2(string[] data)
        {
            Stack<char>[] storage = new Stack<char>[9];

            for (int y = 7; y >= 0; --y)
            {
                for (int x = 1, j = 0; x < 36; x += 4, j++)
                {
                    if (storage[j] == null) storage[j] = new Stack<char>();

                    char c = data[y][x];
                    if (char.IsWhiteSpace(c)) continue;
                    storage[j].Push(c);
                }
            }

            for (int i = 10; i < data.Count(); ++i)
            {
                var split = Regex.Matches(data[i], @"\d+").OfType<Match>().Select(m => m.Value).ToArray();// Regex.Match(data[i], "/[0-9]+/g");
                var parse = split.Select(x => int.Parse(x.ToString())).ToArray();
                int[] directions = parse;

                var tmpstack = new Stack<char>();

                for (int m = 0; m < directions[0]; ++m)
                {
                    tmpstack.Push(storage[directions[1] - 1].Pop());
                }
                for (int m = 0; m < directions[0]; ++m)
                {
                    storage[directions[2] - 1].Push(tmpstack.Pop());
                }
            }

            string output = "";
            foreach (var s in storage)
            {
                output += s.Pop();
            }

            return output;
        }
    }
}
namespace adventofcode.source
{
    public static class Day3
    {
        public static string Part1(string[] data)
        {
            int total = 0;

            foreach (var line in data)
            {
                int index = line.Length / 2;
                string[] split = new string[]
                {
                    line.Substring(0, index),
                    line.Substring(index, index)
                };

                var dups = split[0].Where(x => split[1].Contains(x)).Distinct();

                foreach (char c in dups)
                {
                    int v = (int)c;
                    int priority = 0;
                    if (v > 95)//lowercase
                    {
                        priority = v - 96;
                    }
                    else
                    {
                        priority = v - 64;
                        priority += 26;
                    }

                    Console.WriteLine($"{c} with: {priority} total: {total}");
                    total += priority;
                }
            }

            return total.ToString();
        }

        public static string Part2(string[] data)
        {
            int[] total = new[] { 0, 0, 0 };
            for (int i = 0, count = 0; i <= data.Count() - 1; i += 3)
            {
                int team = count / 3;

                var dups = data[i].Where(x => data[i + 1].Contains(x) && data[i + 2].Contains(x)).Distinct();

                foreach (char c in dups)
                {
                    int v = (int)c;
                    int priority = 0;
                    if (v > 95)//lowercase
                    {
                        priority = v - 96;
                    }
                    else
                    {
                        priority = v - 64;
                        priority += 26;
                    }

                    Console.WriteLine($"{c} with: {priority} total: {total}");
                    total[team] += priority;
                }

                ++count;
                if (count >= 9) count = 0;
            }

            return total.Sum().ToString();
        }
    }
}
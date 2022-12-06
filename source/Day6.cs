namespace adventofcode.source
{
    public static class Day6
    {
        public static string Part1(string[] data)
        {
            int total = 0;
            int distinctAmount = 4;
            string input = data[0];
            total = GetIndex(distinctAmount, input);

            return total.ToString();
        }

        public static string Part2(string[] data)
        {
            int total = 0;
            int distinctAmount = 14;
            string input = data[0];
            total = GetIndex(distinctAmount, input);

            return total.ToString();
        }

        private static int GetIndex(int distinctAmount, string input)
        {
            for (int i = distinctAmount; i < input.Length; ++i)
            {
                var chars = input[(i - distinctAmount)..(i)];
                if (!OnlyOnceCheck(chars))
                {
                    return i;
                    break;
                }
            }

            return -1;
        }

        private static bool OnlyOnceCheck(string input)
        {
            var set = new HashSet<char>();
            return input.Any(x => !set.Add(x));
        }
    }
}
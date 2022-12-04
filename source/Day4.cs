namespace adventofcode.source
{
    public static class Day4
    {
        public static string Part1(string[] data)
        {
            int total = 0;

            foreach (var line in data)
            {
                string[] teams = line.Split(',');
                (int low, int high) team1 = ConvertToSplitTuple(teams[0]);
                (int low, int high) team2 = ConvertToSplitTuple(teams[1]);

                if (team2.low >= team1.low && team2.high <= team1.high ||
                    team1.low >= team2.low && team1.high <= team2.high)
                {
                    ++total;
                }
            }

            return total.ToString();
        }

        public static string Part2(string[] data)
        {
            int total = 0;

            foreach (var line in data)
            {
                string[] teams = line.Split(',');
                (int low, int high) team1 = ConvertToSplitTuple(teams[0]);
                (int low, int high) team2 = ConvertToSplitTuple(teams[1]);

                if (team2.low >= team1.low && team2.low <= team1.high || team2.high >= team1.low && team2.high <= team1.high ||
                     team1.low >= team2.low && team1.low <= team2.high || team1.high >= team2.low && team1.high <= team2.high)
                {
                    ++total;
                }
            }

            return total.ToString();
        }

        private static (int, int) ConvertToSplitTuple(string data)
        {
            var split = data.Split('-');
            return (int.Parse(split[0]), int.Parse(split[1]));
        }
    }
}
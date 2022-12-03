namespace adventofcode.source
{
    public static class Day2
    {
        public static string Part1(string[] data)
        {
            (string p1, string p2)[] split = ConvertToSplitTuple(data);
            Dictionary<string, string[]> plays = new Dictionary<string, string[]>(){
                {"A", new[]{"B","Y"}},
                {"X", new[]{"B","Y"}},
                {"B", new[]{"C","Z"}},
                {"Y", new[]{"C","Z"}},
                {"C", new[]{"A","X"}},
                {"Z", new[]{"A","X"}}
            };

            Dictionary<string, int> scores = new Dictionary<string, int>(){
                {"A", 1},
                {"X", 1},
                {"B", 2},
                {"Y", 2},
                {"C", 3},
                {"Z", 3}
            };

            int myScore = 0;

            foreach (var game in split)
            {

                int p1Score = scores[game.p1];
                int p2Score = scores[game.p2];

                myScore += p2Score;
                Console.WriteLine($"{game.p2} {game.p1} + {p2Score}");

                if (plays[game.p1].Contains(game.p2))
                {
                    Console.WriteLine($"{game.p2} beats {game.p1}");
                    myScore += 6;
                }
                else if (p1Score == p2Score)
                {
                    Console.WriteLine($"{game.p2} draws {game.p1}");
                    myScore += 3;
                }
                else
                {
                    Console.WriteLine($"{game.p2} loose {game.p1}");
                }
            }

            return myScore.ToString();
        }

        public static string Part2(string[] data)
        {
            (string p1, string p2)[] split = ConvertToSplitTuple(data);
            Dictionary<string, string> plays = new Dictionary<string, string>(){
                {"A", "B"},
                {"B", "C"},
                {"C", "A"}
            };

            Dictionary<string, int> scores = new Dictionary<string, int>(){
                {"A", 1},
                {"B", 2},
                {"C", 3}

            };

            int myScore = 0;

            foreach (var game in split)
            {
                int p1Score = scores[game.p1];

                //loss
                if (game.p2 == "X")
                {
                    var p2 = plays.First(x => x.Value == game.p1).Key;
                    myScore += scores[p2];
                }
                else if (game.p2 == "Y")
                {
                    myScore += p1Score;
                    myScore += 3;
                }
                else if (game.p2 == "Z")
                {
                    myScore += scores[plays[game.p1]];
                    myScore += 6;
                }
            }

            return myScore.ToString();
        }

        private static (string direction, string change)[] ConvertToSplitTuple(string[] data)
        {
            return Array.ConvertAll(data, s =>
            {
                var split = s.Split(' ');
                return (split[0], split[1]);
            });
        }
    }
}

using System;
using System.IO;
using System.Reflection;
using adventofcode.source;

namespace adventofcode
{
    class Program
    {
        static void Main(string[] args)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string folder = Directory.GetParent(workingDirectory).FullName + "\\Advent_2022\\";
            string path = Path.Combine(folder, @"data/day4.txt");
            string[] lines = TextParser.ReadLines(path);
            string answer = "";
            //answer = Day1.Part1(lines);
            //answer = Day1.Part2(lines);
            //answer = Day2.Part1(lines);
            //answer = Day2.Part2(lines);
            //answer = Day3.Part1(lines);
            //answer = Day3.Part2(lines);
            answer = Day4.Part2(lines);
            //string Day4Part1Answer = Day4.Part1(lines);
            //string Day4Part2Answer = Day4.Part2(lines);
            //string Day5Part1Answer = Day5.Part1(lines);
            //string Day5Part2Answer = Day5.Part2(lines);
            //string Day6Part1Answer = Day6.Part1(lines);
            //string Day6Part2Answer = Day6.Part2_Good(lines);
            //string Day7Part1Answer = Day7.Part1(lines);
            //string Day7Part2Answer = Day7.Part2(lines);
            //string Day8Part1Answer = Day8.Part1(lines);
            //string Day8Part2Answer = Day8.Part2(lines);
            //string Day9Part1Answer = Day9.Part1(lines);
            //string Day9Part2Answer = Day9.Part2(lines);
            //string Day10Part1Answer = Day10.Part1(lines);
            //string Day10Part2Answer = Day10.Part2(lines);
            //string Day11Part1Answer = Day11.Part1(lines);
            //string Day11Part2Answer = Day11.Part2(lines);
            //string Day12Part1Answer = Day12.Part1(lines);
            //string Day12Part2Answer = Day12.Part2(lines);
            //string Day13Part1Answer = Day13.Part1(lines);
            //string Day13Part2Answer = Day13.Part2(lines);
            //string Day14Part1Answer = Day14.Part1(lines);
            //string Day14Part2Answer = Day14.Part2(lines);
            Console.WriteLine(answer);
            //Console.WriteLine(Day6Part2Answer);
        }
    }
}

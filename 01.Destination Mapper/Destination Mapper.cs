using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace anyway
{
    internal class Program
    {


        static void Main(string[] args)
        {
            {
                string input = Console.ReadLine();

                string pattern = @"(=|\/)(?<location>[A-Z][A-z]{2,})\1";
                MatchCollection matches = Regex.Matches(input, pattern);

                if (Regex.IsMatch(input, pattern))
                {
                    List<string> list = new List<string>();
                    int count = 0;
                    foreach(Match match in matches)
                    {
                        int n = match.Groups["location"].Length;
                        count += n;
                        list.Add(match.Groups["location"].Value);
                    }
                    Console.WriteLine($"Destinations: { String.Join(", ", list)}");
                    Console.WriteLine($"Travel Points: {count}");
                }
                else
                {
                    Console.WriteLine("Destinations:");
                    Console.WriteLine("Travel Points: 0");
                }

            }    
        }
    }
} 
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patern = @"([\@|\#])(?<word>[A-z]{3,})\1\1(?<mirror>[A-z]{3,})\1";
            int counter = 0;
            bool isMirror = false;
            List<string> words = new List<string>();
            List<string> words1 = new List<string>();
            List<string> wordsRev = new List<string>();
            
            MatchCollection matches = Regex.Matches(input, patern);
            if (matches.Count == 0)
            {
                 Console.WriteLine("No word pairs found!");
                 Console.WriteLine("No mirror words!");
                 return;
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            foreach(Match match in matches)
            {
                var word = match.Groups["word"].Value;
                var mirror = match.Groups["mirror"].Value;
                words.Add(word);
                wordsRev.Add(mirror);
            }
            foreach(string word in words)
            {
                foreach(string wordRev in wordsRev)
                {
                    string wordReversed = null;
                    for (int i = wordRev.Length - 1; i >= 0; i--)
                    {
                         wordReversed += wordRev[i];

                    }
                    if (word == wordReversed)
                    {
                        counter++;
                        isMirror = true;
                       words1.Add(word + " <=> " + wordRev);
                        
                    }
                   
                    
                    
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            if (isMirror)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", words1));
                
            }

        }
    }
}
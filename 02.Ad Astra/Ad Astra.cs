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
                string pattern = @"(\||#)(?<name>[A-Z][a-z]+|[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<kalories>[\d]{1,5})\b";
                double sum = 0;


                
                
                 MatchCollection maches = Regex.Matches(input, pattern);
                
                foreach (Match match in maches)
                {

                    
                    int kalories = int.Parse(match.Groups["kalories"].Value);
                    sum += kalories;


                }
                Console.WriteLine($"You have food to last you for: {Math.Floor(sum/2000)} days!");




                foreach (Match match in maches)
                    {
                        
                    string nameproducts = match.Groups["name"].Value;
                    string  date = match.Groups["date"].Value;
                    int kalories = int.Parse(match.Groups["kalories"].Value);
                    Console.WriteLine($"Item: {nameproducts}, Best before: {date}, Nutrition: {kalories}");

                }

                

            }   
        }
    }
}
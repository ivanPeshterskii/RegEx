﻿using System.Text.RegularExpressions;

namespace MatchDates;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string pattern = @"\b(?<day>\d{2})([./-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
        
        Regex regex = new Regex(pattern);

        MatchCollection matchCollection = regex.Matches(input);

        foreach (Match match in matchCollection)
        {
            string date = match.Groups["day"].Value;
            string month = match.Groups["month"].Value;
            string year = match.Groups["year"].Value;

            Console.WriteLine($"Day: {date}, Month: {month}, Year: {year}");
        }

    }
}

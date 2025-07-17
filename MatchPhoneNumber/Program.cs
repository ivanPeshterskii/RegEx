using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"(?<=\s|^)\+359([ -])2\1\d{3}\1\d{4}\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            var validMatches = matches
                .Cast<Match>()
                .Select(m => m.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", validMatches));
        }
    }
}
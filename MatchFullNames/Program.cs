using System.Text.RegularExpressions;


namespace MatchFullNames;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

        Regex regex = new Regex(pattern);

        MatchCollection matchCollection = regex.Matches(input);

        foreach (Match match in matchCollection)
        {
            Console.Write(match.Value + " ");
        }
    }
    
}


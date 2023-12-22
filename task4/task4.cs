using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] smileys = { ":)", ";D", ":-D", ":~)", ";-)", ":>", ":}", ":]" };

        int count = CountSmileys(smileys);
        Console.WriteLine($"Total number of smileys: {count}");
    }
    static int CountSmileys(string[] arr)
    {
        return arr.Count(smiley =>
        (smiley.Length == 2 || smiley.Length == 3) &&
        (smiley[0] == ':' || smiley[0] == ';') &&
        (smiley[1] == '~' || smiley[1] == '-') &&
        (smiley.Length == 2 || smiley[2] == ')' || smiley[2] == 'D')
        );
    }
}

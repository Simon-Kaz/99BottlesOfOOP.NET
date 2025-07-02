using System.Text;

namespace Bottles;

public class Bottles
{
    public string Song() => Verses(99, 0);

    public string Verse(int number)
    {
        var bottleNumber = BottleNumber.For(number);

        return $"{Capitalize($"{bottleNumber}")} of beer on the wall, " +
               $"{bottleNumber} of beer.\n" +
               bottleNumber.Action() +
               $"{bottleNumber.Successor()} of beer on the wall.\n";
    }

    public string Verses(int upper, int lower)
    {
        var result = new StringBuilder();
        for (int i = upper; i >= lower; i--)
        {
            result.Append(Verse(i));
            if (i > lower)
                result.AppendLine();
        }

        return result.ToString();
    }

    private static string Capitalize(string input) =>
        input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
            _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
        };
}
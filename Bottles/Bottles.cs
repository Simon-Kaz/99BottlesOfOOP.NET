using System.Text;

namespace Bottles;

public class Bottles
{
    public string Song() => Verses(99, 0);

    public string Verse(int number)
        => $"{Capitalize(Quantity(number))} {Container(number)} of beer on the wall, " +
           $"{Quantity(number)} {Container(number)} of beer.\n" +
           Action(number) +
           $"{Quantity(Successor(number))} {Container(Successor(number))} of beer on the wall.\n";

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

    private string Container(int number) =>
        number switch
        {
            1 => "bottle",
            _ => "bottles"
        };

    private string Pronoun(int number) =>
        number switch
        {
            1 => "it",
            _ => "one"
        };

    private string Quantity(int number)
        => number switch
        {
            0 => "no more",
            _ => number.ToString()
        };


    private static string Capitalize(string input) =>
        input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
            _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
        };

    private string Action(int number)
        => number switch
        {
            0 => "Go to the store and buy some more, ",
            _ => $"Take {Pronoun(number)} down and pass it around, "
        };

    private int Successor(int number) => number switch
    {
        0 => 99,
        _ => number - 1
    };
}
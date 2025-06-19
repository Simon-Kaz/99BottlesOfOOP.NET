using System.Text;

namespace Bottles;

public class Bottles
{
    public string Song() => Verses(99, 0);

    public string Verse(int count)
    {
        return count switch
        {
            0 => "No more bottles of beer on the wall, " +
                 "no more bottles of beer.\n" +
                 "Go to the store and buy some more, " +
                 "99 bottles of beer on the wall.\n",

            1 => "1 bottle of beer on the wall, " +
                 "1 bottle of beer.\n" +
                 "Take it down and pass it around, " +
                 "no more bottles of beer on the wall.\n",
            
            _ => $"{count} bottles of beer on the wall, " +
                 $"{count} bottles of beer.\n" +
                 "Take one down and pass it around, " +
                 $"{count - 1} {Container(count - 1)} of beer on the wall.\n"
        };
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

    private string Container(int number) =>
        number switch
        {
            1 => "bottle",
            _ => "bottles"
        };
}
namespace Bottles;

public class BottleNumber(int number)
{
    public string Quantity()
        => number switch
        {
            0 => "no more",
            _ => number.ToString()
        };

    public string Container() =>
        number switch
        {
            1 => "bottle",
            _ => "bottles"
        };

    public string Action()
        => number switch
        {
            0 => "Go to the store and buy some more, ",
            _ => $"Take {Pronoun()} down and pass it around, "
        };

    public string Pronoun() =>
        number switch
        {
            1 => "it",
            _ => "one"
        };

    public int Successor() => number switch
    {
        0 => 99,
        _ => number - 1
    };
}
namespace Bottles;

public abstract class BottleNumber(int number)
{
    protected readonly int number = number;

    public static BottleNumber For(int number)
        => number switch
        {
            0 => new ZeroBottleNumber(),
            1 => new OneBottleNumber(),
            6 => new SixBottleNumber(),
            _ => new RegularBottleNumber(number)
        };

    public abstract string Quantity();
    public abstract string Container();
    public abstract string Action();
    public abstract string Pronoun();
    public abstract BottleNumber Successor();
    public override string ToString() => $"{Quantity()} {Container()}";
}
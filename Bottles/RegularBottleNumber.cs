namespace Bottles;

public class RegularBottleNumber(int number) : BottleNumber(number)
{
    private readonly int _number = number;
    public override string Quantity() => _number.ToString();
    public override string Container() => "bottles";
    public override string Action() => $"Take {Pronoun()} down and pass it around, ";
    public override string Pronoun() => "one";
    public override BottleNumber Successor() => For(number - 1);
}
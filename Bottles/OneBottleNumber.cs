namespace Bottles;

[HandlesNumber(1)]
public class OneBottleNumber() : BottleNumber(1)
{
    public override string Quantity() => "1";

    public override string Container() => "bottle";
    public override string Action() => $"Take {Pronoun()} down and pass it around, ";
    public override string Pronoun() => "it";
    public override BottleNumber Successor() => For(0);
}
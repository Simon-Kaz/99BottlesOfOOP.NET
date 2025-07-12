namespace Bottles;

[HandlesNumber(6)]
public class SixBottleNumber() : BottleNumber(6)
{
    public override string Quantity() => "1";
    public override string Container() => "six-pack";
    public override string Action() => $"Take {Pronoun()} down and pass it around, ";
    public override string Pronoun() => "one";
    public override BottleNumber Successor() => For(5);
}
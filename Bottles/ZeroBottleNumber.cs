namespace Bottles;

[HandlesNumber(0)]
public class ZeroBottleNumber() : BottleNumber(0)
{
    public override string Quantity() => "no more";
    public override string Container() => "bottles";
    public override string Action() => "Go to the store and buy some more, ";
    public override string Pronoun() => "one";
    public override BottleNumber Successor() => For(99);
}
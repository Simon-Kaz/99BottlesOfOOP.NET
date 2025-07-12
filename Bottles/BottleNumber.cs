using System.Reflection;

namespace Bottles;

public abstract class BottleNumber(int number)
{
    protected readonly int number = number;

    public static BottleNumber For(int number)
    {
        var type = BottleNumberRegistry.GetTypeForNumber(number);
        if (type == typeof(RegularBottleNumber))
            return new RegularBottleNumber(number);

        return (BottleNumber) Activator.CreateInstance(type)!;
    }

    public abstract string Quantity();
    public abstract string Container();
    public abstract string Action();
    public abstract string Pronoun();
    public abstract BottleNumber Successor();
    public override string ToString() => $"{Quantity()} {Container()}";
}
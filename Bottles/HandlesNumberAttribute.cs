namespace Bottles;

public class HandlesNumberAttribute : Attribute
{
    public int Number { get; }

    public HandlesNumberAttribute(int number)
    {
        Number = number;
    }
}
using System.Reflection;

namespace Bottles;

public static class BottleNumberRegistry
{
    private static readonly Dictionary<int, Type> Registrations = new();
    private static readonly Type FallbackType = typeof(RegularBottleNumber);

    static BottleNumberRegistry()
    {
        RegisterAllTypes();
    }

    private static void RegisterAllTypes()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var bottleNumberTypes = assembly.GetTypes()
            .Where(type => !type.IsAbstract && type.IsSubclassOf(typeof(BottleNumber)));

        foreach (var type in bottleNumberTypes)
        {
            var attributes = type.GetCustomAttributes<HandlesNumberAttribute>();
            foreach (var attribute in attributes)
                Registrations[attribute.Number] = type;
        }
    }

    public static Type GetTypeForNumber(int number) => Registrations.GetValueOrDefault(number, FallbackType);

    public static IReadOnlyDictionary<int, Type> GetRegistrations => Registrations;
}
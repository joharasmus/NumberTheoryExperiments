namespace NumberTheoryExperiments;

internal static class IO
{
    public static string Stringify<T>(this IEnumerable<T> items)
    {
        var content = string.Join(", ", items);

        return $"[{content}]";
    }

    public static void Print<T>(this T item)
    {
        Console.WriteLine(item);
    }

    public static void Print<T>(this IEnumerable<T> items)
    {
        Console.WriteLine(items.Stringify());
    }
}

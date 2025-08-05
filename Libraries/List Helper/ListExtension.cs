namespace ListHelper;

public static class ListExtension
{
    private static readonly Random s_random = new Random();

    
    public static T GetRandomItem<T>(this IList<T> values) => values[s_random.Next(values.Count)];
    public static T GetFirst<T>(this IList<T> values) => values.First();
    public static T GetLast<T>(this IList<T> values) => values.Last();
}

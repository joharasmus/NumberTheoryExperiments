
namespace NumberTheoryExperiments;

internal static class GCDandLCM
{
    public static int GCD(int int1, int int2)
    {
        if (int1 == 0 && int2 == 0) return 0;

        if (int1 == 0) return Math.Abs(int2);
        if (int2 == 0) return Math.Abs(int1);

        if (int1 < 0) return GCD(-1 * int1, int2);
        if (int2 < 0) return GCD(int1, -1 * int2);

        if (int1 < int2) return GCD(int2, int1);
        return GCD(int2, int1 % int2);
    }

    public static int GCD(params int[] ints)
    {
        if (ints.Length == 0) throw new ArgumentException("Must send at least 1 arg into method.");

        if (ints.Length == 1) return ints[0];

        var gcd = ints[0];
        for (int i = 1; i < ints.Length; i++)
        {
            gcd = GCD(gcd, ints[i]);
        }

        return gcd;
    }

    public static int GCD(this (int, int) pair)
        => GCD(pair.Item1, pair.Item2);

    public static int GCD(this (int, int, int) triple)
        => GCD(triple.Item1, triple.Item2, triple.Item3);

    public static int LCM(int int1, int int2)
    {
        if (int1 == 0 && int2 == 0) return 0; // Special case
        return Math.Abs(int1 * int2) / GCD(int1, int2);
    }

    public static int LCM(params int[] ints)
    {
        if (ints.Length == 0) throw new ArgumentException("Must send at least 1 arg into method.");

        if (ints.Length == 1) return ints[0];

        var lcm = ints[0];
        for (int i = 1; i < ints.Length; i++)
        {
            lcm = LCM(lcm, ints[i]);
        }

        return lcm;
    }

    public static int LCM(this (int, int) pair)
        => LCM(pair.Item1, pair.Item2);

    public static int LCM(this (int, int, int) triple)
        => LCM(triple.Item1, triple.Item2, triple.Item3);
}

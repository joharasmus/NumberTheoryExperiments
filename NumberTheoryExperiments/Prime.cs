
namespace NumberTheoryExperiments;

public static class Prime
{
    /// <summary>
    /// Very primitive method for deducing whether an int is a prime or not.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Bool telling whether the int is prime.</returns>
    public static bool IsPrime(this int value)
    {
        if (value < 1) throw new ArgumentOutOfRangeException(nameof(value));

        if (value == 1) return false;

        if (value == 2 || value == 3) return true;

        if (value % 2 == 0) return false;

        for (int divisor = 3; divisor * divisor <= value; divisor += 2) 
        { 
            if (value % divisor == 0) return false;
        }

        return true;
    }

    /// <summary>
    /// Very primitive method for deducing whether a long is a prime or not.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Bool telling whether the long is prime.</returns>
    public static bool IsPrime(this long value)
    {
        if (value < 1) throw new ArgumentOutOfRangeException(nameof(value));

        if (value == 1) return false;

        if (value == 2 || value == 3) return true;

        if (value % 2 == 0) return false;

        for (long divisor = 3; divisor * divisor <= value; divisor += 2)
        {
            if (value % divisor == 0) return false;
        }

        return true;
    }

    /// <summary>
    /// Very primitive method for deducing whether a BigInteger is a prime or not. This is very slow for large numbers.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>Bool telling whether the BigInteger is prime.</returns>
    public static bool IsPrime(this BigInteger value)
    {
        if (value < 1) throw new ArgumentOutOfRangeException(nameof(value));

        if (value == 1) return false;

        if (value == 2 || value == 3) return true;

        if (value % 2 == 0) return false;

        for (BigInteger divisor = 3; divisor * divisor <= value; divisor += 2)
        {
            if (value % divisor == 0) return false;
        }

        return true;
    }

    public static List<int> PrimeFactors(this int value)
    {
        if (value < 1) throw new ArgumentOutOfRangeException(nameof(value));

        if (value < 4) return new List<int>() { value };

        var factors = new List<int>();

        // First, deal with the 2:s; since those are weird (even) primes

        while (value % 2 == 0)
        {
            factors.Add(2);
            value /= 2;
        }

        // Here goes the rest

        int divisor = 3;

        while (value > 1)
        {
            if ((value % divisor) == 0)
            {
                factors.Add(divisor);
                value /= divisor;
            }
            else
            {
                divisor += 2;
            }
        }

        return factors;
    }

    public static List<long> PrimeFactors(this long value)
    {
        if (value < 1) throw new ArgumentOutOfRangeException(nameof(value));

        if (value < 4) return new List<long>() { value };

        var factors = new List<long>();

        // First, deal with the 2:s; since those are weird (even) primes

        while (value % 2 == 0)
        {
            factors.Add(2);
            value /= 2;
        }

        // Here goes the rest

        long divisor = 3;

        while (value > 1)
        {
            if ((value % divisor) == 0)
            {
                factors.Add(divisor);
                value /= divisor;
            }
            else
            {
                divisor += 2;
            }
        }

        return factors;
    }

}

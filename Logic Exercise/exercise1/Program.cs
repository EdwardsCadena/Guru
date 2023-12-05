int i = 10;
int n = 5;

foreach (var prime in GeneratePrimes().SkipWhile(p => p < i).Take(n))
{
    Console.WriteLine(prime);
}
static bool IsPrime(int number)
{
    if (number < 2) return false;
    for (int i = 2; i * i <= number; i++)
    {
        if (number % i == 0) return false;
    }
    return true;
}

static IEnumerable<int> GeneratePrimes()
{
    for (int i = 2; ; i++)
    {
        if (IsPrime(i)) yield return i;
    }
}

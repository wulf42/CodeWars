static List<string> cards()
{
    static IEnumerable<string> Typ()
    {
        yield return "clubs";
        yield return "diamonds";
        yield return "hearts";
        yield return "spades";
    }

    static IEnumerable<string> Wartosc()
    {
        yield return "two";
        yield return "three";
        yield return "four";
        yield return "five";
        yield return "six";
        yield return "seven";
        yield return "eight";
        yield return "nine";
        yield return "ten";
        yield return "jack";
        yield return "queen";
        yield return "king";
        yield return "ace";
    }

    var deck = (from t in Typ()
                from w in Wartosc()
                select $"{w} of {t}")
                .ToList();

    return deck;
}
static void foo()
{
    int[] tab = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    var query =
        from v in tab
        where v % 2 == 0
        select v;

    foreach (var v in query)
    {
        Console.Write("{0} ", v);
    }
}
static void foo2()
{
    int[] numbers = {
                1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
            };

    var query = from n in numbers
                where n > 0
                where n < 12
                select n;

    foreach (var n in query)
    {
        Console.Write($"{n} ");
    }
}
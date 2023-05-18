﻿using CodeWars;

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

    var deck = (
                from t in Typ()
                from w in Wartosc()
                select $"{w} of {t}"
                ).ToList();

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

    var query =
                from n in numbers
                where n > 0
                where n < 12
                select n;

    foreach (var n in query)
    {
        Console.Write($"{n} ");
    }
}
static void foo3()
{
    int[] arr1 = new[] { 3, 9, 2, 8, 6, 5 };
    var query =
        from n in arr1
        select $"Number = {n} SqrNo = {n * n}";
    var query2 =
        from Number in arr1
        let SqrNo = Number * Number
        select new { Number, SqrNo };
    var query3 = arr1
        .Select(s => new { Number = s, SqrNo = s * s });

    foreach (var v in query3)
    {
        Console.WriteLine("{0}", v);
    }
}
static void foo4()
{
    int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

    var query =
        arr1
        .GroupBy(x => x)
        .Select(x =>
        new { Number = x.Key, Count = x.Count() });

    foreach (var v in query)
    {
        Console.WriteLine(v);
    }
}
static void foo5(string text)
{
    var query = text
        .GroupBy(c => c)
        .Select(c => new { Letter = c.Key, Count = c.Count() });

    foreach (var pair in query)
    {
        Console.WriteLine(pair);
    }
}
static void foo6()
{
    string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

    var query = dayWeek
        .Select(d => d);
    foreach (string day in query)
    {
        Console.WriteLine(day);
    }
}
static void foo7()
{
    int[] numbers = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

    var query = numbers
        .GroupBy(n => n)
        .Select(n =>
        new { Number = n.Key, Result = n.Key * n.Count(), Count = n.Count() });
    foreach (var n in query)
    {
        Console.WriteLine(n);
    }
}
static void foo8(char start, char end)
{
    string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

    var query = cities
        .Select(c => c)
        .Where(c => c.StartsWith(start))
        .Where(c => c.EndsWith(end));

    foreach (var c in query)
    {
        Console.WriteLine(c);
    }
}
static void foo9()
{
    List<int> templist = new() { 55, 200, 740, 76, 230, 482, 95 };

    var query = templist
        .Select(n => n)
        .Where(n => n > 80);

    foreach (int item in query)
    {
        Console.WriteLine(item);
    }
}
static void foo11(int count)
{
    List<int> templist = new() { 5, 7, 13, 24, 6, 9, 8, 7 };

    var query = templist
        .OrderByDescending(n => n)
        .Select(n => n).Take(count);

    foreach (int item in query)
    {
        Console.WriteLine(item);
    }
}
static void foo12(string text)
{
    var query = text
        .Split(' ')
        .Select(s => s)
        .Where(s => String.Equals(s, s.ToUpper()));

    foreach (var item in query)
    {
        Console.WriteLine(item);
    }
}
static string foo13(string[] ar) => String.Join(", ", ar);
static void foo14(int n)
{
    Students s = new Students();
    var studentlist = s.GtStuRec();

    var query2 = studentlist
        .Select(s => s)
        .OrderByDescending(s => s.GrPoint)
        .Take(n);

    foreach (var item in query2)
    {
        Console.WriteLine($"Id: {item.StuId}, Name: {item.StuName}, achieved Grade Point: {item.GrPoint}");
    }
}
static void foo15()
{
    string[] arr1 = { "xd.pl.txt", "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

    var query = arr1
        .Select(s => s.Substring(s.LastIndexOf('.') + 1).ToLower())
        .GroupBy(s => s)
        .Select(s => new { Count = s.Count(), Extension = s.Key });

    foreach (var item in query)
    {
        Console.WriteLine(item);
    }
}

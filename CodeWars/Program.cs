// solutions

using System.Numerics;

string greet() => "hello world!";
int DoubleInteger(int n) => 2 * n;

int GetVowelCount(string str)
{
    char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
    int vowelCount = 0;
    foreach (char letter in str)
    {
        if (vowel.Contains(letter))
            vowelCount++;
    }
    return vowelCount;
}

string SpinWords(string sentence)
{
    foreach (string word in sentence.Split(' '))
    {
        if (word.Length >= 5)
        {
            sentence = sentence.Replace(word, new string(word.Reverse().ToArray()));
        }
    }
    return sentence;
}

double[] Tribonacci(double[] signature, int n)
{
    double[] result = new double[n];
    if (n >= 1)
    {
        result[0] = signature[0];
    }
    if (n >= 2)
    {
        result[1] = signature[1];
    }
    if (n >= 3)
    {
        result[2] = signature[2];
    }
    if (n >= 4)
    {
        for (int i = 3; i < n; i++)
        {
            result[i] = result[i - 3] + result[i - 2] + result[i - 1];
        }
    }

    return result;
}

int FindEvenIndex(int[] arr)
{
    int leftSum = 0;
    int rightSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        leftSum += arr[i];
        for (int j = i; j < arr.Length; j++)
        {
            rightSum += arr[j];
        }
        if (rightSum == leftSum)
        {
            return i;
        }
        rightSum = 0;
    }

    return -1;
}

int[] BubbleSort(int[] array)
{
    int temp;
    int changes;
    bool isSorted = false;

    while (!isSorted)
    {
        changes = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                temp = array[i + 1];
                array[i + 1] = array[i];
                array[i] = temp;
                changes++;
            }
        }
        if (changes == 0)
        {
            isSorted = true;
        }
    }
    return array;
}
int CountOdd(int[] array)
{
    int count = 0;
    foreach (int value in array)
    {
        count += value % 2;
    }
    return count;
}
int[] SortArray(int[] array)    //even(2,4,6...) stay, sort odd (1,3,5...)           //bubble sort implemented
{
    int evenSize = CountOdd(array);
    int[] even = new int[evenSize];
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            even[k] = array[i];
            k++;
        }
    }

    BubbleSort(even);

    k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            array[i] = even[k];
            k++;
        }
    }

    return array;
}
string Rgb(int r, int g, int b)
{
    r = (r <= 0) ? 0 : (r >= 255) ? 255 : r;
    g = (g <= 0) ? 0 : (g >= 255) ? 255 : g;
    b = (b <= 0) ? 0 : (b >= 255) ? 255 : b;
    return string.Format("{0:x2}{1:x2}{2:x2}", r, g, b).ToUpper();
}

public static class Kata
{
    public static int sumOfNumbersDivisibleBy3or5(int value)
    {
        int sum = 0;
        for (int i = 3; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
                sum += i;
        }
        return sum;
    }

    public static string Rot13(string input)
    {
        char[] characters = input.ToCharArray();
        for (int i = 0; i < characters.Length; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                if ((characters[i] >= 65 && characters[i] <= 90) || (characters[i] >= 97 && characters[i] <= 122))
                {
                    characters[i]++;
                    if (characters[i] == '{')
                    {
                        characters[i] = 'a';
                    }
                    else if (characters[i] == '[')
                    {
                        characters[i] = 'A';
                    }
                }
            }
        }
        return new string(characters);
    }

    public static bool comp(int[] a, int[] b)
    {
        if (a == null || b == null || a.Length != b.Length) return false;

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length; j++)
            {
                if (a[i] * a[i] == b[j])
                {
                    b[j] = 0;
                    break;
                }
            }
        }
        for (int i = 0; i < b.Length; i++)
        {
            if (b[i] != 0) return false;
        }

        return true;
    }

    public static string GetReadableTime(int seconds)
    {
        int hours = seconds / 3600;
        int minutes = seconds / 60 % 60;
        seconds = seconds % 60;
        return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
    }

    public static int GetLastDigit(BigInteger n1, BigInteger n2) => (int)BigInteger.ModPow(n1, n2, 10);

    public static List<object> JosephusPermutation(List<object> items, int k)
    {
        if (k == 1)
        {
            return items;
        }
        List<object> result = new List<object>();
        int index = 0;

        while (items.Count > 0)
        {
            index = (index + k - 1) % items.Count;
            result.Add(items[index]);
            items.RemoveAt(index);
        }
        return result;
    }

    public static int DuplicateCount(string str) => str.ToLower().GroupBy(c => c).Count(g => g.Count() > 1);

    public static bool ValidatePin(string pin) => pin.All(Char.IsDigit) && (pin.Length == 4 || pin.Length == 6);

    public static string GetMiddle(string s)
    {
        if (s.Length % 2 == 0)
        {
            return s.Substring(s.Length / 2 - 1, 2);
        }
        else
        {
            return s.Substring(s.Length / 2, 1);
        }
    }

    public static string FindNeedle(object[] haystack)
    {
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i].Equals("needle"))
            {
                return string.Format("found the needle at position {0}", i);
            }
        }
        return string.Format("the needle not found");
    }

    public static int PositiveSum(int[] arr)
    {
        int sum = 0;
        foreach (int value in arr)
        {
            sum += (value > 0) ? value : 0;
        }
        return sum;
    }

    public static string AbbrevName(string name)
    {
        string[] names = name.Split(' ');
        return string.Format("{0}.{1}", names[0].First(), names[1].First()).ToUpper();
    }
}
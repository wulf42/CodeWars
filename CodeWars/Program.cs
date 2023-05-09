// solutions
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


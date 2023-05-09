﻿// solutions
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
    public static int Solution(int value)
    {
        int x = 0;
        for (int i = 3; i < value; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
                x += i;
        }
        return x;
    }
}
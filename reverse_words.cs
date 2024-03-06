using System;

class Program
{
    static void Main()
    {
        string inputString1 = "The weather is so sunny nowadays";
        string inputString2 = "Life is so beautiful";

        string outputString1 = ReverseWords(inputString1);
        string outputString2 = ReverseWords(inputString2);

        Console.WriteLine(outputString1);
        Console.WriteLine(outputString2);
    }

    static string ReverseWords(string input)
    {
        string[] words = input.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}

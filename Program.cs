using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir string ifade girin: ");
        string input = Console.ReadLine();

        string result = SwapFirstAndLastCharacters(input);
        Console.WriteLine("Output: " + result);
    }

    static string SwapFirstAndLastCharacters(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 2)
            return input;

        char[] charArray = input.ToCharArray();

        char firstChar = charArray[0];
        charArray[0] = charArray[input.Length - 1];
        charArray[input.Length - 1] = firstChar;

        return new string(charArray);
    }
}

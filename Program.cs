Task1


namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Split("salam",      " Dunya"));
        }
        public static string Split(string word1, string word2)
        {
            return (word1 + ' ' + word2);
        }
    }
}  





Task 2

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Contain("Salam123"));
    }

    static bool Contain(string word)
    {
        bool containsDigit = false;
        bool containsUpper = false;
        bool containsLower = false;
        foreach (char c in word)
        {
            if (char.IsDigit(c))
            {
                containsDigit = true;
            }
            else if (char.IsUpper(c))
            {
                containsUpper = true;
            }
            else if (char.IsLower(c))
            {
                containsLower = true;
            }
        }


        if (containsDigit && containsUpper && containsLower)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}





Task3


class Program
{
    static void Main()
    {

        Console.WriteLine(Starstwith("test tapsiqlari"));
    }

    static string Starstwith(string word)
    {
        string firstWord = "";


        for (int i = 0; i < word.Length; i++)
        {

            if (word[i] != ' ')
            {
                firstWord += word[i];
            }
            else
            {
                break;
            }
        }

        return firstWord;
    }
}

/*
Create a function that takes a word and returns true if the word has two consecutive identical letters.

Examples
DoubleLetters("loop") ➞ true
DoubleLetters("yummy") ➞ true
DoubleLetters("orange") ➞ false
DoubleLetters("munchkin") ➞ false
*/

public class Program
{
    public static bool DoubleLetters(string word)
{
    if (string.IsNullOrEmpty(word) || word.Length < 2)
    {
        return false;
    }

    for (int i = 0; i < word.Length - 1; i++)
    {
        if (word[i] == word[i + 1])
        {
            return true;
        }
    }

    return false;
}
}

/*
Create a function that returns true if an input string contains only uppercase or only lowercase letters.

Examples
SameCase("hello") ➞ true
SameCase("HELLO") ➞ true
SameCase("Hello") ➞ false
SameCase("ketcHUp") ➞ false
*/

using System.Linq;

public class Program
{
    public static bool SameCase(string str)
    {
			return !string.IsNullOrEmpty(str) && (str.All(char.IsUpper) || str.All(char.IsLower));
    }
}

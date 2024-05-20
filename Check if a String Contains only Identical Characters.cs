/*
Write a function that returns true if all characters in a string are identical and false otherwise.

Examples
- isIdentical("aaaaaa") ➞ true
- isIdentical("aabaaa") ➞ false
- isIdentical("ccccca") ➞ false
- isIdentical("kk") ➞ true
*/

using System.Linq;

public class Program
{
    public static bool isIdentical(string str)
		{
    		return !string.IsNullOrEmpty(str) && str.All(c => c == str[0]);
		}
}

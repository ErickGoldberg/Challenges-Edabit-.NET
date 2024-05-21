using System.Linq;
using System;

public class Program
{
    public static bool IsPalindrome(int num)
{
    string numString = num.ToString();
    string reversedNumString = new string(numString.Reverse().ToArray());
    
    return numString == reversedNumString;
}
}

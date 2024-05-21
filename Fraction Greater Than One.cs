public static bool GreaterThanOne(string str)
{
    var x = str.Split('/');
    int numerator = Convert.ToInt32(x[0]);
    int denominator = Convert.ToInt32(x[1]);

    return numerator > denominator;
}

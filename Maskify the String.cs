public static string Maskify(string str)
{
    if (str.Length <= 4)
        return str;
    
    return str.Substring(0, str.Length - 4).PadLeft(str.Length, '#');
}

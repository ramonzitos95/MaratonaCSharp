public static string SearchingChallenge(string str)
{
    string longestPalindrome = "none";
    int maxLength = 0;

    for (int i = 0; i < str.Length; i++)
    {
        for (int j = i; j < str.Length; j++)
        {
            string substring = str.Substring(i, j - i + 1);

            if (IsPalindrome(substring) && substring.Length > maxLength)
            {
                maxLength = substring.Length;
                longestPalindrome = substring;
            }
        }
    }

    if (maxLength <= 2)
    {
        return "none";
    }

    return longestPalindrome;
}

public static bool IsPalindrome(string str)
{
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}

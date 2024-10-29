using System.Text.RegularExpressions;

namespace _125_Valid_Palindrome;

class Program
{
    static void Main(string[] args)
    {
        var case1 = "A man, a plan, a canal: Panama";
        var case2 = "race a car";
        var case3 = " ";

        Console.WriteLine(char.IsDigit('0'));

        Console.WriteLine(case2.Where(char.IsLetter).ToArray());
        Console.WriteLine(IsPalindrome("0P"));
    }
    
    public static bool IsPalindrome(string s)
    {
        var text = s.ToLower().Where(x => char.IsLetterOrDigit(x)).ToArray();
        for (int i = 1; i < text.Length ; i++)
        {
            var firstIndex = i - 1;
            var secondIndex = text.Length - i;
            if (char.ToLower(text[firstIndex]) != char.ToLower(text[secondIndex]))
            {
                return false;
            }
        }
        
        return true;
    }
}
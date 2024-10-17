namespace _13._Roman_to_Integer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(RomanToInt("LVIII"));

        int RomanToInt(string s)
        {

            var chars = s.ToCharArray();
            var result = 0;
            var currentValue = 0;
            for (var i = 0; i < chars.Length - 1; i++)
            {
                currentValue = RomanNumerals(chars[i]);
                result += (RomanNumerals(chars[i + 1]) > currentValue ? -1 : 1) * currentValue;
            }

            return result + RomanNumerals(chars[chars.Length - 1]);
        }

        int RomanNumerals(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
            };
            return 0;
        }
    }
 
}

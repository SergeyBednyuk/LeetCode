namespace _49_group_anagrams;

class Program
{
    static void Main(string[] args)
    {
        var c1 = new [] {"eat", "tea", "tan", "ate", "nat", "bat"};
        var c2 = new [] { "" };
        var c3 = new[] { "a" };

        var result = GroupAnagrams(c1);
        foreach (var l in result)
        {
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=================");
        }
    }
    
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var d1 = new Dictionary<String, List<String>>();
        for (int i = 0; i < strs.Length; i++)
        {
            var chars = strs[i].ToCharArray();
            Array.Sort(chars);
            var sorted = new string(chars);
            if (!d1.ContainsKey(sorted))
            {
                d1[sorted] = new List<String>();
            }
            d1[sorted].Add(strs[i]);
        }
        return d1.Values.ToList<IList<String>>();
    }
}
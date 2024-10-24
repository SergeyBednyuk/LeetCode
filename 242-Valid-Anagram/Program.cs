namespace _242_Valid_Anagram;

class Program
{
	static void Main(string[] args)
	{
		var s = "aacc";
		var t = "ccac";

		bool IsAnagram(string s, string t)
		{
			if(s.Length != t.Length)
			{
				return false;
			}

			var arrS = s.ToArray();
			var arrT = t.ToArray();
			Array.Sort(arrS);
			Array.Sort(arrT);
			
			return arrS.SequenceEqual(arrT);
		}


	}
}

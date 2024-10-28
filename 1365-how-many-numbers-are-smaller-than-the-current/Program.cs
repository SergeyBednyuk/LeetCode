namespace _1365_how_many_numbers_are_smaller_than_the_current;

class Program
{
    static void Main(string[] args)
    {
        var case1 = new int[] { 8, 1, 2, 2, 3 };
        var case2 = new int[] { 6, 5, 4, 8 };
        var case3 = new int[] { 7, 7, 7, 7 };

        var result = new List<int>();
        //Case 1
        result = SmallerNumbersThanCurrent(case1).ToList();
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
        //Case 2
        result = SmallerNumbersThanCurrent(case2).ToList();
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
        //case 3
        result = SmallerNumbersThanCurrent(case3).ToList();
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
        Console.ReadKey();
    }
    
    internal static int[] SmallerNumbersThanCurrent(int[] nums) {
        var result = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++)
        {
            int search = i;
            for(int j = 0; j < nums.Length; j++)
            {
                if(nums[search] > nums[j]){
                    result[search] +=1;
                }
            }
        }

        return result;
    }
}
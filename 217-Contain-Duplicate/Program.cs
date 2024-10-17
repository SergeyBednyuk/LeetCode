namespace _217_Contain_Duplicate;

class Program
{
    static void Main(string[] args)
    {
        var case1 = new int[] { 1, 2, 3, 1 };
        var case2 = new int[] { 1, 2, 3, 4 };
        var case3 = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

        Console.WriteLine(ContainsDuplicateBySort(case1));
        Console.WriteLine(ContainsDuplicateBySort(case2));
        Console.WriteLine(ContainsDuplicateBySort(case3));
        
        System.Console.ReadKey();
    }

    public static bool ContainsDuplicate(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            var item = nums[i];

            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j && item == nums[j])
                {
                    return true;
                }
            }
        }
        return false;
    }

    //My best solution
    public static bool ContainsDuplicateBySort(int[] nums)
    {
        Array.Sort(nums);

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i -1])
            {
                return true;
            }
        }

        return false;
    }
}

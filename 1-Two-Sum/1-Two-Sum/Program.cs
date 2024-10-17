namespace _1_Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 3, 2, 4 };
            int target1 = 6;

            var r1 = TwoSum(nums1, target1);
            foreach (int x in r1)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();

            int[] TwoSum(int[] nums, int target)
            {
                var result = new int[2] { -1, -1};

                for (int i = 0; i < nums.Length; i++)
                {
                    if (result[0] != -1)
                    {
                        break;
                    }
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target && i != j)
                        {
                            result[0] = i;
                            result[1] = j;
                            break;
                        }
                    }
                }

                return result;
            }
        }
    }
}

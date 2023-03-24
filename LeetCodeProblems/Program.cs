namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        }

        public int[] TwoSum(int[] nums, int target)
        {

            Dictionary<int, int> seen = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (seen.ContainsKey(target - nums[i]))
                    return new int[] { seen[target - nums[i]], i };
                if (!seen.ContainsKey(nums[i]))
                    seen.Add(nums[i], i);
            }
            return null;
        }
    }
}
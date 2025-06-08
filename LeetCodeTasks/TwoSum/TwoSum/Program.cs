namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 7, 11, 15};
            int target = 18;

            int[] result = TwoSum(array, target);
            
            foreach (int number in result)
            {
                Console.Write($"{number} ");
            }
        }

        static public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return null;
        }
    }
}
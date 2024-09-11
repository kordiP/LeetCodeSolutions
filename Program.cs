namespace LeetCodeSolutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return [i, j];
                    }
                }
            }
            return [0, 0];
        }

        public int FindMaxK(int[] nums)
        {
            int largestNumber = -1;
            foreach (var number in nums)
            {
                if (nums.Contains(number * (-1)) && number > largestNumber)
                {
                    largestNumber = number;
                }
            }
            return largestNumber;
        }

        public static IList<string> CommonChars(string[] words)
        {
            List<string> result = words[0].Select(x => x.ToString()).ToList();
            for (int i = 1; i < words.Length; i++)
            {
                for (int j = 0; j < result.Count; j++)
                {
                    if (!words[i].Contains(result[j]))
                    {
                        result.Remove(result[j]);
                    }
                }
            }
            return result;
        }

        public int ClimbStairs(int n)
        {
            int a = 2, b = 3, temp;

            for (int i = 2; i < n; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
            }

            if (n == 1) return n;
            return a;
        }

        public int ArrangeCoins()
        {
            int n = 4;
            int counter = 0;

            for (; n > 0; n -= counter) { Console.WriteLine(n); }

            return n < 0 ? --counter : counter;
        }
    }
}

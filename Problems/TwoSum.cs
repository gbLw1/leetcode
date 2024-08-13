namespace leetcode.Problems;

public class TwoSum
{
    /// <summary>
    /// 1. Two Sum => https://leetcode.com/problems/two-sum/
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    private static int[] Solution(int[] nums, int target)
    {
        Dictionary<int, int> visited = [];

        for (int i = 0; i < nums.Length; ++i)
        {
            var currentNumber = nums[i];
            var rest = target - currentNumber;

            if (visited.TryGetValue(rest, out int value))
            {
                return [value, i];
            }

            visited.TryAdd(currentNumber, i);
        }

        return [-1, -1];
    }

    public static void Test()
    {
        Dictionary<int[], int> cases = new() {
            { [2, 7, 11, 15], 9 },
            { [3, 2, 4], 6 },
            { [3, 3], 6 },
            { [1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1], 11 }
        };

        foreach (var c in cases)
        {
            Console.WriteLine(string.Join(",", Solution(c.Key, c.Value)));
        }
    }
}

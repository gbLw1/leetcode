namespace leetcode.Problems;

public class FibonacciNumber
{
    /// <summary>
    /// 509. Fibonacci Number => https://leetcode.com/problems/fibonacci-number/
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    private static int Solution(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        int[] sum = new int[n + 1]; // sum[n] is the sum of all
        sum[0] = 0;
        sum[1] = 1;
        for (int i = 2; i <= n; i++)
        {
            sum[i] = sum[i - 1] + sum[i - 2];
        }

        return sum[n];
    }

    public static void Test()
    {
        int[] cases = [2, 3, 4];

        foreach (var c in cases)
        {
            Console.WriteLine(Solution(c));
        }
    }
}

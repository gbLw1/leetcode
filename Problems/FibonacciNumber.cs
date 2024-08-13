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
        if (n <= 1) return n;
        return Solution(n-1) + Solution(n-2);
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

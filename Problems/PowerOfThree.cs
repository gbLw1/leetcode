namespace leetcode.Problems;

public class PowerOfThree
{
    /// <summary>
    /// 326. Power of Three => https://leetcode.com/problems/power-of-three/
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    private static bool Solution(int n)
    {
        if (n <= 0)
        {
            return false;
        }

        // n = 27 
        // 3^x = 27 
        // x = 27 % 3 = 0 => n = n / 3
        // x = 9 % 3 = 0 => n = n / 3
        // x = 3 % 3 = 1 => true

        while (n % 3 == 0)
        {
            n /= 3;
        }

        return n == 1;
    }

    public static void Test()
    {
        int[] cases = [27, 0, -1, 9];

        foreach (var c in cases)
        {
            Console.WriteLine(Solution(c));
        }

    }
}

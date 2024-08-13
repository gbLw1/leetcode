namespace leetcode.Problems;

public class FizzBuzz
{
    /// <summary>
    /// 411. Fizz Buzz => https://leetcode.com/problems/fizz-buzz/ 
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    private static IList<string> Solution(int n)
    {
        IList<string> arr = [];
        for (int i = 1; i <= n; ++i)
        {
            if (i % 15 == 0)
            {
                arr.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                arr.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                arr.Add("Buzz");
            }
            else
            {
                arr.Add(i.ToString());
            }
        }
        return arr;
    }

    public static void Test()
    {
        int[] cases = [3, 5, 15];

        foreach (var c in cases)
        {
            Console.WriteLine(string.Join(",", Solution(c)));
        }
    }
}

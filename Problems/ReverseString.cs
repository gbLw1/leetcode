namespace leetcode.Problems;

public class ReverseString
{

    /// <summary>
    /// 344. Reverse String => https://leetcode.com/problems/reverse-string/
    /// </summary>
    /// <param name="s"></param>
    private static void Solution(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            (s[left], s[right]) = (s[right], s[left]);

            left++;
            right--;
        }

        Console.WriteLine(s); // test
    }

    public static void Test()
    {
        char[][] cases = [
            ['h','e','l','l','o'],
            ['H','a','n','n','a','h']
        ];

        foreach (var c in cases)
        {
            Solution(c);
        }
    }
}

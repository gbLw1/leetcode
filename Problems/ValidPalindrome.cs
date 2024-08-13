using System.Text;

namespace leetcode.Problems;

public class ValidPalindrome
{
    /// <summary>
    /// 125. Valid Palindrome => https://leetcode.com/problems/valid-palindrome/
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    private static bool Solution(string s)
    {
        s = s.Trim().ToLower();
        var sb = new StringBuilder();
        foreach (var c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                sb.Append(c);
            }
        }

        string fmtStr = sb.ToString();
        int left = 0;
        int right = fmtStr.Length - 1;

        while (left < right)
        {
            if (fmtStr[left++] != fmtStr[right--])
            {
                return false;
            }
        }

        return true;
    }

    public static void Test()
    {
        string[] cases = [
            "A man, a plan, a canal: Panama",
            "race a car",
            " ",
            "Um teste? não pode faltar!",
        ];

        foreach (var c in cases)
        {
            Console.WriteLine(Solution(c));
        }
    }
}

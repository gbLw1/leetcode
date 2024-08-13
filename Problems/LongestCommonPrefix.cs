namespace leetcode.Problems;

public class LongestCommonPrefix
{

    /// <summary>
    /// 14. Longest Common Prefix
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    private static string Solution(string[] strs)
    {
        if (strs.Length == 0)
        {
            return string.Empty;
        }

        string baseWord = strs[0];
        for (int i = 0; i < baseWord.Length; ++i)
        {
            for (int j = 1; j < strs.Length; ++j)
            {
                string currentStr = strs[j];
                // currentStr is out of bounds
                // or current char is different
                if (i == currentStr.Length || currentStr[i] != baseWord[i])
                {
                    return baseWord[..i];
                }
            }
        }

        return baseWord;
    }

    public static void Test()
    {
        string[][] cases = [
            ["flower","flow","flight"],
            ["dog","racecar","car"],
            ["ab", "a"],
        ];

        foreach (var c in cases)
        {
            Console.WriteLine(Solution(c));
        }
    }
}

namespace leetcode.Problems;

public class ValidAnagram
{
    /// <summary>
    /// 242. Valid Anagram => https://leetcode.com/problems/valid-anagram/
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    private static bool Solution(string s, string t)
    {
        if (s.Length == 0) return false;

        if (t.Length == 0) return false;

        if (s.Length != t.Length) return false;

        Dictionary<char, int> letterFrequency = [];

        for (int i = 0; i < s.Length; ++i)
        {
            letterFrequency[s[i]] = letterFrequency.GetValueOrDefault(s[i]) + 1;
            letterFrequency[t[i]] = letterFrequency.GetValueOrDefault(t[i]) - 1;
        }

        return letterFrequency.Values.All(v => v == 0);
    }

    public static void Test()
    {
        Dictionary<string, string> cases = new()
        {
            { "anagram", "nagaram" },
            { "rat", "car" }
        };

        foreach (var c in cases)
        {
            Console.WriteLine(Solution(c.Key, c.Value));

        }
    }
}

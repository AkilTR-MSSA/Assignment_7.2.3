string s = "clinteastwood";
string t = "oldwestaction";
Console.WriteLine($"s = {s}");
Console.WriteLine($"t = {t}");
Console.WriteLine(ValidAnagram(s, t));

bool ValidAnagram(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }
    int n = s.Length;
    int[] sMap = new int[26];
    int[] tMap = new int[26];
    for(int i = 0; i < n; i++)
    {
        sMap[s[i] - 'a']++;
        tMap[t[i] - 'a']++;
    }
    for(int i = 0; i < 26; i++)
    {
        if (sMap[i] != tMap[i])
        {
            return false;
        }
    }
    return true;

}
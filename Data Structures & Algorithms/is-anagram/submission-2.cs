public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        return false;
        var hashMap = new Dictionary<char,int>();
        foreach(char c in s)
        {
            if(hashMap.ContainsKey(c))
            hashMap[c]++;
            else
            hashMap.Add(c,1);
        }

        foreach(char c in t)
        {
            if(!hashMap.ContainsKey(c))
            {
                return false;
            }
            else if(hashMap[c] == 1)
            {
                hashMap.Remove(c);
            }
            else
            {
                hashMap[c]--;
            }
        }
        return true;

    }
}

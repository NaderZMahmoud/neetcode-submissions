public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var results = new List<List<string>>();
        if(strs.Length ==1)
        {
            results.Add(strs.ToList());
            return results;
        }

        
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        for(int i = 0; i< strs.Length; i++)
        {
            var sortedArray = strs[i].ToCharArray();
            Array.Sort(sortedArray);
            var sortedString = new String(sortedArray);
            if(map.ContainsKey(sortedString))
            {
                map[sortedString].Add(strs[i]);
            }
            else
            {
                map.Add(sortedString, new List<string>(){strs[i]});
            }
        }
        foreach( var item in map)
        {
            results.Add(item.Value);
        }
        return results;
    }
}

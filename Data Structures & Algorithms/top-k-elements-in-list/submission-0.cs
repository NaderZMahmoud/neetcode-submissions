public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        /*var map = new Dictionary<int,int>();
        for(int i = 0; i< nums.Length; i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            }
            else
            {
                map.Add(nums[i], 1);
            }
        }
        var result = map.OrderByDescending(x=> x.Value).Take(k).Select(kvp=> kvp.Key).ToArray();
        return result;*/

        var frequencyDic = nums.GroupBy(n => n).OrderByDescending(g=> g.Count()).Take(k);
        return frequencyDic.Select(kvp => kvp.Key).ToArray();
    }
}

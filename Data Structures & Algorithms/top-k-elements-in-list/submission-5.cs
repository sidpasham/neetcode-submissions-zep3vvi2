public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int> result = new List<int>();

        Dictionary<int, int> counts = new Dictionary<int, int>();

        for(int i=0;i<nums.Count();i++) {
            if(counts.ContainsKey(nums[i])) {
                counts[nums[i]]++;
            } else {
                counts.Add(nums[i], 1);
            }            
        }

        var dict = new Dictionary<int, List<int>>();

        foreach(var kv in counts) {
            if(dict.ContainsKey(kv.Value)) {
                dict[kv.Value].Add(kv.Key);
            } else {
                dict.Add(kv.Value, new List<int>{kv.Key});
            }            
        }

        foreach(var kv in dict.OrderByDescending(x => x.Key)) {
            if(result.Count() == k) {
                return result.ToArray();
            }

            result.AddRange(kv.Value);
        }

        return result.ToArray();
    }
}

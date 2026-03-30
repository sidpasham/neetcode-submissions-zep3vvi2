public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int> result = new List<int>();

        Dictionary<int, int> dict = new Dictionary<int, int>();

        // counts
        for(int i=0; i < nums.Length;i++) {
            if (dict.ContainsKey(nums[i])) {
                dict[nums[i]] = dict[nums[i]] + 1;
            } else {
                dict.Add(nums[i], 1);
            }
        }

        foreach(var kv in dict.OrderByDescending(x => x.Value)) {
            if(result.Count() == k) {
                return result.ToArray();
            }
            result.Add(kv.Key);
        }

        return result.ToArray();
    }
}

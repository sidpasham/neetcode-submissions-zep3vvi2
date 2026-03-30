public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int> result = new List<int>();

        var mapCounts = new Dictionary<int, int>();

        // calculate counts
        for(int i =0; i<nums.Length;i++) {
            if(mapCounts.ContainsKey(nums[i])) {
                mapCounts[nums[i]]++;
            } else {
                mapCounts.Add(nums[i], 1);
            }
        }

        // [1, 3], [2, 2], [ 3, 1]
        var freq = new SortedDictionary<int, List<int>>();

        foreach(var kv in mapCounts) {
            if(freq.ContainsKey(kv.Value)) {
                freq[kv.Value].Add(kv.Key);
            } else {
                freq.Add(kv.Value, new List<int> {kv.Key});
            }

        }

        // [3, 1], [2, 2], [3, 1]

        int counter = 0;

        foreach(var kv in freq.Reverse()) {
            foreach(var val in kv.Value) {
                if (counter == k) {
                    return result.ToArray();
                }
                result.Add(val);
                counter++;
            }

        }

        return result.ToArray();
    }
}

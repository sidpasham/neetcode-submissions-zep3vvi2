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

        // [1, 1], [2, 2], [3, 3]
        // [7, 2], [1, 4]
        int counter = 0;

        foreach(var kv in mapCounts.OrderByDescending(x => x.Value)) {
            // [1, 4], [7, 2]
            if(counter == k) { // 0!=2, 1!=2, 2=2
                return result.ToArray(); // 3, 2
            }
            // 3, 2
            // 4, 7
            result.Add(kv.Key); 
            counter++; // 1, 2,
        }

        return result.ToArray();
    }
}

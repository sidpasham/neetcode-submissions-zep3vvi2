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

        var pq = new PriorityQueue<int, int>();

        foreach(var kv in dict) {
            pq.Enqueue(kv.Key, kv.Value);

            if (pq.Count > k) {
                pq.Dequeue();
            }
        }

        for(int i = 0; i < k;  i++) {
            result.Add(pq.Dequeue());
        }

        return result.ToArray();
    }
}

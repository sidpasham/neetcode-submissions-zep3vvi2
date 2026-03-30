public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        // edge cases
        if (nums.Count() == 0) {
            return new int[] {};
        }

        var map = new Dictionary<int, int>();

        for(int i =0; i<nums.Length;i++) {
            var findJ = target - nums[i];
            if(map.ContainsKey(findJ)) {
                return new int[] {map[findJ], i};
            }

            map.Add(nums[i], i);
        }

        return new int[] {};
    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        // edge cases
        if (nums.Count() == 0) {
            return new int[] {};
        }

        var dict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Count(); i++) {
            int findVal = target - nums[i];

            if (dict.ContainsKey(findVal)) {
                return new int[] {dict[findVal], i};
            }

            dict.Add(nums[i], i);
        }

        return new int[] {};
    }
}

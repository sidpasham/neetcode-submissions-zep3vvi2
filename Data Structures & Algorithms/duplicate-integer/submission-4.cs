public class Solution {
    public bool hasDuplicate(int[] nums) {

        List<int> hs = new List<int>();

        for(int i = 0; i<nums.Length;i++) {
            if(hs.Contains(nums[i])) {
                return true;
            }
            hs.Add(nums[i]);
        }
        
        return false;
    }
}
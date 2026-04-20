public class Solution {
    public int Search(int[] nums, int target) {
        // edge cases

        int l = 0;
        int r = nums.Length-1;

        while (l <= r) {
            // avoid overflow
            int m = l + ((r-l)/2);

            if(target < nums[m]) {
                r = m -1;
            }
            else if (target > nums[m]) {
                l = m+1;
            }
            else if (target == nums[m]) {
                return m;
            }
        }
        return -1;        
    }
}

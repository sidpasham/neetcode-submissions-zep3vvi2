public class Solution {
    public int FindMin(int[] nums) {
        // TODO edgecases

        int l = 0;
        int r = nums.Length - 1;
        int min = 1000;

        while(l <= r) {
            if(nums[l] < nums[r]) {
                min = Math.Min(min, nums[l]);
                break;
            }

            int m = l + (r-l)/2;

            min = Math.Min(min, nums[m]);

            if(nums[l] <= nums[m]) {
                l = m + 1;
            } else {
                r = m - 1;
            }

        }

        return min;
    }
}

public class Solution {
    public int FindDuplicate(int[] nums) {
        // negative marking
        foreach(var num in nums) {
            var index = Math.Abs(num) - 1;

            if(nums[index] < 0) {
                return Math.Abs(num);
            }

            nums[index] = nums[index] * -1;
        }

        return -1;        
    }
}

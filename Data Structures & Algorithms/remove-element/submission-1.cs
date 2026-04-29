public class Solution {
    public int RemoveElement(int[] nums, int val) {
        // edge cases

        int index =0;

        foreach(var num in nums) {
            if(num != val) {
                nums[index] = num;
                index++;
            }
        }

        return index;
    }
}
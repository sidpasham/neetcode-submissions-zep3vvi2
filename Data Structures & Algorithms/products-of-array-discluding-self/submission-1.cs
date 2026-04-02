public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // edge cases

        //declarations
        int[] result = new int[nums.Length];
        
        // prefix
        int prefix = 1;
        
        for(int i=0; i<nums.Length; i++) {
            result[i] = prefix;
            prefix = prefix * nums[i];
        }
        // postfix
        int postfix = 1;

        for(int i=nums.Length-1; i>=0; i--) {
            result[i] = result[i] * postfix;
            postfix = postfix * nums[i];
        }

        return result;
    }
}

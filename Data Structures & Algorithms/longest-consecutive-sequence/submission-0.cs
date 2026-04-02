public class Solution {
    public int LongestConsecutive(int[] nums) {
        //edge cases

        HashSet<int> hs = new HashSet<int>();
        for(int i =0; i<nums.Length;i++) {
            hs.Add(nums[i]);
        }
        int maxc = 0;

        for(int i =0; i<nums.Length;i++) {
            int c = 1;
            int j = 1;
            while(hs.Contains(nums[i] + j)) {
                c++;
                j++;
            }

            if(c > maxc) maxc = c;
        }

        return maxc;
        
    }
}

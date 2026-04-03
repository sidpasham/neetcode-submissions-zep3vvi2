public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        //edgecases

        int l = 0;
        int r = numbers.Length-1;

        while(l<r) {
            int sum = numbers[l] + numbers[r];

            if(sum == target) {
                return new int[] {l+1, r+1};
            }

            if(sum < target) {
                l++;
            }
            else if (sum > target) {
                r--;
            }
        }

        return new int[] {0, 0};       
    }
}

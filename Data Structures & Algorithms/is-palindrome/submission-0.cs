public class Solution {
    public bool IsPalindrome(string s) {

        // edge cases

        int l = 0;
        int r = s.Length -1;

        s = s.ToLower();

        while(l < r) {
            if(!char.IsLetterOrDigit(s[l])) {
                l++;
                continue;
            }
            if(!char.IsLetterOrDigit(s[r])) {
                r--;
                continue;
            }

            if(s[l] != s[r]) {
                return false;
            }

            l++;
            r--;
        }

        return true;
        
    }
}

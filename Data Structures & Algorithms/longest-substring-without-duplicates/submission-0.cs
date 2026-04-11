public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // edgecases

        int l =0;
        int r =0;
        int max =0;
        var map = new HashSet<char>();

        while(r < s.Length) {
            while(map.Contains(s[r])) {                
                map.Remove(s[l]);
                l++;
            }
            map.Add(s[r]);
            max = Math.Max(max, r - l+1);
            r++;            
        }

        return max;

    }
}

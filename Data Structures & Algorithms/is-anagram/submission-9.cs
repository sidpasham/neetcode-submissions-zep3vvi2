public class Solution {
    public bool IsAnagram(string s, string t) {
        // edge cases
        if (s.Length != t.Length) {
            return false;
        }

        if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t)) {
            return false;
        }

        int[] countS = new int[256];
        int[] countT = new int[256];

        for(int i=0;i<s.Length;i++) {
            countS[s[i]]++;
            countT[t[i]]++;
        }

        foreach(var c in s){
            if(countS[c] != countT[c]) {
                return false;
            }
        }

        return true;
    }
}

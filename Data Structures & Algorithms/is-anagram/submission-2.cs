public class Solution {
    public bool IsAnagram(string s, string t) {
        // edge cases
        if (s.Length != t.Length) {
            return false;
        }

        if (string.IsNullOrEmpty(s) && string.IsNullOrEmpty(t)) {
            return false;
        }

        // increment the counts
        int[] countS = new int[256];
        int[] countT = new int[256];

        foreach(var c in s) {
            countS[c]++;
        }

        foreach(var c in t) {
            countT[c]++;
        }

        // check for unequal counts
        foreach(var c in s) {
            if (countS[c] != countT[c]) {
                return false;
            }
        }

        return true;
    }
}

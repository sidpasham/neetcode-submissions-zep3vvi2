public class Solution {
    public bool CheckInclusion(string s1, string s2) {

        // if s1 is longer than s2, then return false
        if (s1.Length > s2.Length) {
            return false;
        }


        int[] s1Count = new int[26];
        int[] windowCount = new int[26];

        for(int i =0; i<s1.Length; i++) {
            s1Count[s1[i] - 'a']++;
            windowCount[s2[i] - 'a']++;
        }

        if(Enumerable.SequenceEqual(s1Count, windowCount)) {
            return true;
        }

        for(int i = s1.Length; i<s2.Length;i++) {
            windowCount[s2[i] - 'a']++;
            windowCount[s2[i - s1.Length] - 'a']--;

            if(Enumerable.SequenceEqual(s1Count, windowCount)) {
                return true;
            }
        }

        return false;
        
    }
}

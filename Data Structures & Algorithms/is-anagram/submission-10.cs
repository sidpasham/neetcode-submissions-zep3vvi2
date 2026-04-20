public class Solution {
    public bool IsAnagram(string s, string t) {
        //edgecases
        if(s.Length != t.Length) {
            return false;
        }

        var sCount = new int[256];
        var tCount = new int[256];

        for(int i =0; i <s.Length;i++) {
            sCount[s[i]]++;
            tCount[t[i]]++;
        }

        foreach(var c in s) {
            if(sCount[c] != tCount[c]) {
                return false;
            }
        }

        return true;
    }
}

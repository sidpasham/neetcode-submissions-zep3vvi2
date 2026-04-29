public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        // TODO edgecases

        var first = strs[0];
        string prefix = "";

        for(int i = 0; i< first.Length; i++) {
            foreach(var str in strs) {
                if(i == str.Length || first[i] != str[i]) {
                    return prefix;
                }
            }
            prefix = prefix + first[i];
        }

        return prefix;
        
    }
}
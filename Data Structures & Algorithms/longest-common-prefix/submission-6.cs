public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        // TODO edgecases

        var first = strs[0];
        StringBuilder prefix = new StringBuilder("");

        for(int i = 0; i< first.Length; i++) {
            foreach(var str in strs) {
                if(i == str.Length || first[i] != str[i]) {
                    return prefix.ToString();
                }
            }
            prefix.Append(first[i]);
        }

        return prefix.ToString();
        
    }
}
public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        // edge cases
        if (strs.Count() == 0) {
            return new List<List<string>>();
        }

        var dict = new Dictionary<string, List<string>>();

        foreach(var s in strs) {
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sorted = new string(charArray);

            if(dict.ContainsKey(sorted)) {
                dict[sorted].Add(s);
            } else {
                dict.Add(sorted, new List<string> {s});
            }            
        }

        return dict.Values.ToList();        
    }
}
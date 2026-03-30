public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        // edge cases
        if (strs.Count() == 0) {
            return new List<List<string>>();
        }

        var dict = new Dictionary<string, List<string>>();

        foreach(var s in strs) {
            string sorted = SortedString(s);

            if(dict.ContainsKey(sorted)) {
                dict[sorted].Add(s);
            } else {
                dict.Add(sorted, new List<string> {s});
            }            
        }

        return dict.Values.ToList();        
    }

    public string SortedString(string input) {

        var inputChar = input.ToCharArray();

        Array.Sort(inputChar);

        return new string(inputChar);
    }
}
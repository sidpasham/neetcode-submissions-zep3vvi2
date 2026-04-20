public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // edgecases

        var map = new Dictionary<string, List<string>>();

        foreach(var str in strs) {
            var key = Sort(str);

            if(map.ContainsKey(key)) {
                map[key].Add(str);
            } else {
                map.Add(key, new List<string>() {str});
            }
        }

        return map.Values.ToList();
    }

    public string Sort(string str) {
        var chararr = str.ToCharArray();

        Array.Sort(chararr);

        return new String(chararr);
    }
}

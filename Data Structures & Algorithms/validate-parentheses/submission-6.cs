public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        for(int i =0; i< s.Length; i++) {
            if(s[i] == '(') {
                stack.Push(')');
                continue;
            }
            if(s[i] == '[') {
                stack.Push(']');
                continue;
            }
            if(s[i] == '{') {
                stack.Push('}');
                continue;
            }
            if(stack.Count == 0 || stack.Pop() != s[i]) {
                return false;
            }
        }

        if(stack.Count() > 0) {
            return false;
        }

        return true;
    }
}

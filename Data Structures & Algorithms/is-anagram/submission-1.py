class Solution:
    def isAnagram(self, s: str, t: str) -> bool:

        ## edge cases
        if len(s) != len(t):
            return False
        
        if s == '' and t == '':
            return True

        ## load all chars into ascii array
        countS, countT = {}, {}
        for i in range(len(s)):
            countS[s[i]] = countS.get(s[i], 0) + 1
            countT[t[i]] = countT.get(t[i], 0) + 1

        ## return output
        return countS == countT

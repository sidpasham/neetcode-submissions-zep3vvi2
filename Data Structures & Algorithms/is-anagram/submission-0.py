class Solution:
    def isAnagram(self, s: str, t: str) -> bool:

        ## edge cases
        if len(s) != len(t):
            return False
        
        if s == '' and t == '':
            return True

        ## load all chars into ascii array
        arr1 = collections.defaultdict(int)
        for c in s:
            arr1[c] += 1


        ## load all chars into ascii array
        arr2 = collections.defaultdict(int)
        for c in t:
            arr2[c] += 1

        ## count of each char in s = count of each char in t
        for c in arr1:
            if arr1[c] != arr2[c]:
                return False

        ## return output
        return True

class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        ## edge cases
        if(len(nums) == 0):
            return False        

        ## create a set
        s = set()

        ## check if a number exists in set
        for i in nums:
            if i in s:
                return True
            else:
                s.add(i)

        ## return output
        return False

        
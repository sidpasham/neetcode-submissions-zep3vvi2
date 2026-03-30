class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        ## edge cases
        if len(nums) == 0:
            return

        ## calculate the formula
        ## nums[i] = target - nums[j]
        ## check if nums[i] is present in target - nums[j]
        pMap = {}
        for i, n in enumerate(nums):
            findJ = target - n

            if findJ in pMap:
                return [pMap[findJ], i]
            else:
                pMap[n] = i


        ##return
        return

        
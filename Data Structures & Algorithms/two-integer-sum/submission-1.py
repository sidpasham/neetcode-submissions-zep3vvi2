class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        ## edge cases
        if len(nums) == 0:
            return [0, 0]

        ## calculate the formula
        ## nums[i] = target - nums[j]
        ## check if nums[i] is present in target - nums[j]
        for i in range(len(nums)):
            findJ = target - nums[i]

            for j in range(len(nums)):
                if findJ == nums[j] and i != j:
                    return [i, j]


        ##return output
        return [0, 0]

        
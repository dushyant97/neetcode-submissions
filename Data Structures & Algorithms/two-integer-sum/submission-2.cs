public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        if(nums.Length == 2 && (nums[0] + nums[1]) == target)
        {
            return new int[]{0,1};
        }
        for(int i = 0; i < nums.Length -1 ; i++)
        {
            for(int j=i+1; j<nums.Length; j++)
            {
                if((nums[i] + nums[j]) == target)
                {
                    return new int[]{i,j};
                }
            }
        }
        return new int[2];
    }
}

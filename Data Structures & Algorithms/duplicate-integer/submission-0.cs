public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> numFrequency = new();
        for(int currNumInd = 0; currNumInd < nums.Length; currNumInd++)
        {
            if(numFrequency.ContainsKey(nums[currNumInd]))
                return true;
            else{
                numFrequency[nums[currNumInd]]=1;
            }
        }
        return false;
    }
}
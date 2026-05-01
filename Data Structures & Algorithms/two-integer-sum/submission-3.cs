public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if (nums.Length < 2) {
            return new int[] { -1, -1 };
        }

        Dictionary<int, int> freq = new();
        freq[target - nums[0]] = 0;

        for (int i = 1; i < nums.Length; i++) {
            if (freq.ContainsKey(nums[i])) {
                return new int[] { freq[nums[i]], i };
            } else {
                freq[target - nums[i]] = i;
            }
        }
        return new int[] { -1, -1 };
    }
}

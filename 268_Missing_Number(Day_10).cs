public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int sum = (n * (n + 1)) / 2;
        int missingNumberSum = 0;
        for (int i = 0; i < n; i++) {
            missingNumberSum += nums[i];
        }
        int missingNumber = sum - missingNumberSum;
        return missingNumber;
    }
}
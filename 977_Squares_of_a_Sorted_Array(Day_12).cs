public class Solution {
    public int[] SortedSquares(int[] nums) {
        int start = 0;
        int end = nums.Length-1;
        int iterator = nums.Length - 1;
        int[] sortedArray = new int[nums.Length];
        while(start <= end){
             if(Math.Abs(nums[start]) > Math.Abs(nums[end])){
                sortedArray[iterator] = nums[start]*nums[start];
                start++;
             }
             else {
                sortedArray[iterator] = nums[end]*nums[end];
                end--;
                
             }
            iterator--;
             
        }
         return sortedArray;
    }
}
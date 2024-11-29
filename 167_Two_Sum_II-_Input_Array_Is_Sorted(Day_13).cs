public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int sum = 0;
        int start = 0;
        int end = numbers.Length-1;
        int[] ind = new int[2];
        while(start<=end){
            sum = numbers[start]+numbers[end];
            if(sum==target){
                ind[0]=start+1;
                ind[1]=end+1;
                return ind;
            }
            else{
                if(sum < target){
                    start++;
                }
                else{
                    end--;
                }
            }
        }
        return new int[0];
        
    }
}
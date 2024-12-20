public class Solution {
    public int Trap(int[] height) {
        int length = height.Length;

        int[] leftMax  = new int[length];
        leftMax[0]= height[0];

        for(int i = 1; i<length; i++){
            leftMax[i]= Math.Max(leftMax[i-1],height[i]);
        }

        int[] rightMax = new int[length];

        rightMax[length-1]= height[length-1];
        for(int i = length-2; i>=0; i--){
            rightMax[i]= Math.Max(rightMax[i+1],height[i]);
        }

        int sum = 0;
        for(int j = 0; j < length ; j++){
            sum+=Math.Min(leftMax[j],rightMax[j])-height[j];
        }
        return sum;
    }
}
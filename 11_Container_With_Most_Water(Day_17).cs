public class Solution {
    public int MaxArea(int[] height) {

        int start = 0;
        int end = height.Length - 1;
        int maxCap = 0;

        while(start < end){
            int minHeight = Math.Min(height[start],height[end]);
            int width = end - start;
            int currentCap = minHeight * width;
            maxCap = Math.Max(maxCap,currentCap);
            if(height[start] < height[end]){
                start++;
            }
            else{
                end--;
            }
        }
        return maxCap;
    }
}
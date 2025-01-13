public class Solution {
    public int MaxPower(string s) {
        int max = 1;
        int count = 1;
        for(int i = 1; i<s.Length; i++){
            char current = s[i];
            char previous = s[i-1];

            if(current == previous){
                count++;
            }
            else{
                max = Math.Max(count,max);
                count = 1;
            }
        }

        max = Math.Max(count,max);
        return max;
    }
}
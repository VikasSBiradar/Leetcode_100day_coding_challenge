public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int, bool> dt = new Dictionary<int, bool>();
        foreach(var i in nums){
            dt[i] = false;
        }

        foreach(var key in dt.Keys.ToList()){
            if(!dt.ContainsKey(key-1)){
                dt[key]= true;
            }
        }

        int max = 0;
        foreach(var key in dt.Keys.ToList()){
            int k = 1;
            if(dt[key]==true){
                while(dt.ContainsKey(key + k) == true){
                        k++;
                }
            }
            max = Math.Max(max,k);
        }
        return max;

    }
}
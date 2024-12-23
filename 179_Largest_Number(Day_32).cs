public class Solution {
    public string LargestNumber(int[] nums) {
        String[] numsString = new String[nums.Length];
        for(int i = 0; i < nums.Length; i++){
                numsString[i]= nums[i].ToString();
        }
        Array.Sort(numsString, (x,y)=> (y+x).CompareTo(x+y));
        if(numsString[0]=="0"){
            return "0";
        }

        return string.Join("",numsString);
        
    }
}
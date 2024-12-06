public class Solution {
    public int FindLucky(int[] arr) {
        Dictionary<int,int> frequencyArray = new  Dictionary<int,int>();
        for(int i = 0; i<arr.Length; i++){
            int ele = arr[i];
            if(frequencyArray.ContainsKey(ele)){
                frequencyArray[ele]++;
            }
            else{
                frequencyArray[ele] = 1;
            }
        }
        int largestLucky = -1;
        foreach(var entry in frequencyArray){
            int key = entry.Key;
            int value = entry.Value;

            if(key == value){
                largestLucky = Math.Max(largestLucky,key);
            }
        }
        
        return largestLucky;
    }
}
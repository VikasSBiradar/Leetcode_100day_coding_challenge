public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        int start = 0;
        int end = people.Length-1;
        int count = 0;
        Array.Sort(people);
        while(start<=end){
            if(people[start]+people[end] > limit){
                end--;
            }
            else if(people[start]+people[end]<=limit){
                start++;
                end--;
            }
            count++;
        }
        return count;
    }
}
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>();

        for(int i = 0; i<nums.Length; i++){
            if(pq.Count<k){
                pq.Enqueue(nums[i], nums[i]);
            }
            else if(pq.Peek() < nums[i]){
                pq.Dequeue();
                pq.Enqueue(nums[i], nums[i]);
            }
        }
        return pq.Peek();
    }
}
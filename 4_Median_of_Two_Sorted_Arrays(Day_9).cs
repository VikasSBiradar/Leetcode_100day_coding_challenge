public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] ans = mergeSortArray(nums1,nums2);

        if(ans.Length % 2== 0){
            double ans1 = (double)(ans[ans.Length/2] + ans[ans.Length/2 -1])/2;
            return ans1;
        }
        else{
            double ans2 = (double)(ans[ans.Length/2]);
            return ans2;
        }
        
    }

    public int[] mergeSortArray(int[] arr1, int[] arr2){
        int p1 = 0;
        int p2 = 0;
        int p3 = 0;

        int[] ans = new int[arr1.Length + arr2.Length];

        while(p1 < arr1.Length || p2 < arr2.Length){
            int val1 = p1 < arr1.Length ? arr1[p1] : Int32.MaxValue;
            int val2 = p2 < arr2.Length ?arr2[p2] : Int32.MaxValue;


            if(val1 < val2){
                ans[p3] = val1;
                p1++;
            }
            else{
                ans[p3] = val2;
                p2++; 
            }
            p3++;
        }
        return ans;
    }
}
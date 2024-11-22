public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        List<int> arrayForm = new List<int>();
        int n = num.Length, carry = 0;

        for(int i = n-1; i >= 0 ; i--){
            num[i] = num[i] + k%10 + carry;
            arrayForm.Add(num[i]%10);
            carry = num[i]/10;
            k = k/10;
        }
        k = k + carry;
        while(k!=0){
            arrayForm.Add(k%10);
            k= k/10;
        }
        if(arrayForm.Count() > 0 ){
            arrayForm.Reverse();
        }
        return arrayForm;
    }
}
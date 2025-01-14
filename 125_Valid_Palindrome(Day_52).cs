public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length == 1){
            return true;
        }
        StringBuilder sb  = new StringBuilder();
        s = s.ToLower();

        for(int i=0;i <s.Length; i++){
            if(s[i]>='a' && s[i]<='z'){
                sb.Append(s[i]);
            }
            else if(s[i]>='0' && s[i]<='9'){
                sb.Append(s[i]);
            }
        }

        int start = 0;
        int end = sb.Length - 1;

        while(start<end){
            if(sb[start] !=sb[end]){
                return false;
            }
            start++;
            end--;
        }

        return true;
        
    }
}

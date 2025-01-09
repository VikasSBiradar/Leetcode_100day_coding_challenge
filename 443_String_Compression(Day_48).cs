public class Solution {
    public int Compress(char[] chars) {
        int count = 1;
        StringBuilder sb = new StringBuilder("");
        sb.Append(chars[0]);

        for(int i = 1; i<chars.Length;i++){
                if(chars[i-1]!=chars[i]){
                    if(count>1){
                        sb.Append(count+"");
                    }
                    sb.Append(chars[i]);
                    count=1;
                }
                else{
                    count++;
                }
        }
        if(count>1){
            sb.Append(count+"");
        }

        for(int i = 0; i<sb.Length; i++){
            char ch = sb[i];
            chars[i]=ch;
        }

        return sb.Length;
        
    }
}
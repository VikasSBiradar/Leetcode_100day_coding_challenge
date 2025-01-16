public class Solution {
    public int MinAddToMakeValid(string s) {
        Stack<char> st = new Stack<char>();
        int count = 0;


        for(int i = 0; i<s.Length; i++){
            if(s[i]=='('){
                st.Push(s[i]);
            }
            else if(st.Count > 0 && st.Peek() == '('){
                st.Pop();
            }
            else{
                count++;
            }
        }
        int minAddToMakeValid = count + st.Count;

        return minAddToMakeValid;

        
    }
}

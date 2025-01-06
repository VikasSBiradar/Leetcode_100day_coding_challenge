public class Solution {
    public int LengthOfLastWord(string s) {
        int count = 0;
        string trimmedString = s.Trim();
        int lastIndex = trimmedString.Length-1;
        int i = lastIndex;
        while(i>=0 && trimmedString[i] != ' '){
            i--;
            count++;
        }
        return count;
    }
}
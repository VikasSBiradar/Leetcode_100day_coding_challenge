public class Solution {
    public string RemoveDuplicateLetters(string s) {
        int[] lastIndexArray = new int[26];
        
        // Calculate last occurrence of each character
        for (int i = 0; i < s.Length; i++) {
            lastIndexArray[s[i] - 'a'] = i;
        }

        bool[] presentArray = new bool[26];  // To check if a character is already in the stack
        Stack<char> st = new Stack<char>();

        for (int i = 0; i < s.Length; i++) {
            char ch = s[i];
            int idx = ch - 'a';

            // If character is already in the stack, skip it
            if (!presentArray[idx]) {
                // Remove characters that are lexicographically larger and appear later
                while (st.Count > 0 && st.Peek() > ch && lastIndexArray[st.Peek() - 'a'] > i) {
                    presentArray[st.Peek() - 'a'] = false;
                    st.Pop();
                }

                // Push the current character and mark it as present in the stack
                st.Push(ch);
                presentArray[idx] = true;
            }
        }

        // Build the result by popping from the stack
        StringBuilder sb = new StringBuilder();
        while (st.Count > 0) {
            sb.Append(st.Pop());
        }

        // Reverse the string since we've built it backwards
        char[] result = sb.ToString().ToCharArray();
        Array.Reverse(result);
        return new string(result);
    }
}

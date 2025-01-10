public class Solution {
    public string DecodeString(string s) {
        Stack<int> numberStack = new Stack<int>();
        Stack<string> stringStack = new Stack<string>();

        for (int i = 0; i < s.Length; i++) {
            char ch = s[i];

            if (ch >= '0' && ch <= '9') {
                int num = 0;
                while (i < s.Length && s[i] >= '0' && s[i] <= '9') {
                    num = num * 10 + (s[i] - '0');
                    i++;
                }
                i--;
                numberStack.Push(num);
            } else if (ch != ']') {
                stringStack.Push(ch.ToString());
            } else {
                string str = "";
                // Pop characters from stringStack until '[' is found
                while (stringStack.Peek() != "[") {
                    str = stringStack.Pop() + str;
                }
                stringStack.Pop(); // Pop the '['
                int repeatationNumber = numberStack.Pop();
                StringBuilder sb = new StringBuilder();
                while (repeatationNumber > 0) {
                    sb.Append(str);
                    repeatationNumber--;
                }
                stringStack.Push(sb.ToString());
            }
        }

        StringBuilder ans = new StringBuilder();
        while (stringStack.Count > 0) {
            ans.Insert(0, stringStack.Pop());
        }
        return ans.ToString();
    }
}

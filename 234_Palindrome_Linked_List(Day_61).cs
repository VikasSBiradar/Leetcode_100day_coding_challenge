/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        Stack<int> st = new Stack<int>();
        ListNode ptr = head;

        while(ptr != null){
            st.Push(ptr.val);
            ptr = ptr.next;
        }

        ListNode pt = head;
        while(pt != null){
            int val1 = pt.val;
            int val2 = st.Pop();
            if(val1 != val2){
                return false;
            }
            pt = pt.next;
        }
        return true;
    }
}

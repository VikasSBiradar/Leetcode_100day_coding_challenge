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
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null || head.next == null){
            return head;
        }

        ListNode dummy = new ListNode(head.val);
        ListNode ans = dummy;
        ListNode ptr = head.next;


        while(ptr != null){
            if(ptr.val != dummy.val){
                ListNode temp = new ListNode(ptr.val);
                dummy.next = temp;
                dummy = dummy.next;
            }
            ptr = ptr.next;
        }
        return ans;
    }
}

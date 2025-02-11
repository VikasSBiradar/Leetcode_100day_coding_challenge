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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // Create a dummy node to handle edge cases (e.g., removing the first node)
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        
        ListNode first = dummy;
        ListNode second = dummy;

        // Move the first pointer n+1 steps ahead (so that first and second pointers have n nodes between them)
        for (int i = 1; i <= n + 1; i++) {
            first = first.next;
        }

        // Move both first and second pointers until the first reaches the end
        while (first != null) {
            first = first.next;
            second = second.next;
        }

        // Remove the nth node from the end
        second.next = second.next.next;

        // Return the modified list
        return dummy.next;
    }
}

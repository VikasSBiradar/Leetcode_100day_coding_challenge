/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        // Edge case: if the list is empty or has only one element, there can't be a cycle.
        if (head == null || head.next == null) {
            return false;
        }

        // Initialize two pointers
        ListNode slow = head;
        ListNode fast = head;

        // Loop until fast pointer reaches the end or both pointers meet (cycle detected)
        while (fast != null && fast.next != null) {
            slow = slow.next;        // Move slow pointer one step
            fast = fast.next.next;   // Move fast pointer two steps

            // If both pointers meet, we have a cycle
            if (slow == fast) {
                return true;
            }
        }

        // If we reach here, there's no cycle
        return false;
    }
}

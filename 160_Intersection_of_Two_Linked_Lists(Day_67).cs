/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if (headA == null || headB == null) return null;

        // Calculate lengths of both linked lists
        ListNode tempA = headA;
        ListNode tempB = headB;
        int lengthA = 0;
        int lengthB = 0;
        
        while (tempA != null) {
            lengthA++;
            tempA = tempA.next;
        }
        
        while (tempB != null) {
            lengthB++;
            tempB = tempB.next;
        }
        
        // Align the start of both lists
        tempA = headA;
        tempB = headB;

        // Move the pointer of the longer list forward
        if (lengthA > lengthB) {
            for (int i = 0; i < lengthA - lengthB; i++) {
                tempA = tempA.next;
            }
        } else if (lengthB > lengthA) {
            for (int i = 0; i < lengthB - lengthA; i++) {
                tempB = tempB.next;
            }
        }

        // Traverse both lists together and find the intersection node
        while (tempA != null && tempB != null) {
            if (tempA == tempB) {
                return tempA; // Intersection node found
            }
            tempA = tempA.next;
            tempB = tempB.next;
        }

        return null; // No intersection found
    }
}

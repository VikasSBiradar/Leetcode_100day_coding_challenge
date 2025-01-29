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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode temp = new ListNode(-1);
        ListNode ans = temp;
        ListNode p1 = list1;
        ListNode p2 = list2;


        while(p1 != null && p2 != null){
            if(p1.val < p2.val){
                temp.next = p1;
                p1 = p1.next;
            }
            else{
                temp.next = p2;
                p2 = p2.next;
            }
            temp = temp.next;
        }

        if(p1 == null){
            temp.next = p2;
        }
        else{
            temp.next = p1;
        }

        return ans.next;
    }
}

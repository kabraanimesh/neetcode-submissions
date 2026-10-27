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
        ListNode prev = null;
        ListNode slow = head;
        ListNode fast = head;

        // Build n distance
        while (n != 0){
            fast = fast.next; 
            n--;
        }

        // Head has been removed
        if (fast is null){
            return head.next;
        }

        while (fast is not null){
            prev = slow;
            slow = slow.next;
            fast = fast.next;
        }

        // Slow becomes the nth value (from the end)
        // Remove from list
        prev.next = slow.next;

        return head;
    }
}

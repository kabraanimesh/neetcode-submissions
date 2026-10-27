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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode prev = null;
        ListNode head = prev;

        int carry = 0;
        while (l1 != null || l2 != null) {
            int sum = (l1 != null ? l1.val : 0) + 
                        (l2 != null ? l2.val : 0) + carry;

                        int newVal = sum % 10;
                        carry = sum / 10;

                        ListNode curr = new ListNode(newVal);
                        if (prev != null) {
                            prev.next = curr;
                        }
                        else {
                            head = curr;
                        }
                        prev = curr;
                        l1 = l1 != null ? l1.next : null;
                        l2 = l2 != null ? l2.next : null;
        }
        if (carry > 0) {
            prev.next = new ListNode(carry);
        }
        return head;
    }
}

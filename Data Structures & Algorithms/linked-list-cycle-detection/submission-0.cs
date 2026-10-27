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
    public bool HasCycle(ListNode head) {
        var map = new HashSet<ListNode>();
        if (head == null) {
            return false;
        }
        while (head.next != null) {
            if (map.Contains(head)) {
                return true;
            }
            else {
                map.Add(head);
                head = head.next;
            }
        }
        return false;
    }
}

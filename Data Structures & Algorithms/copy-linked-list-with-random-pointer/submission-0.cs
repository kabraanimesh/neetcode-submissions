/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head is null) return null;
        // Original Node -> Copy
        Dictionary<Node, Node> listMap = new ();

        // Create copies first
        Node curr = head;
        while (curr is not null){
            Node copy = new Node(curr.val);
            listMap[curr] = copy;
            curr = curr.next;
        }

        // Link the copies to their respective next and random
        foreach (var (original, copy) in listMap){
            copy.next = original.next != null? listMap[original.next] : null;
            copy.random = original.random != null? listMap[original.random] : null;
        }

        return listMap[head];
    }
}

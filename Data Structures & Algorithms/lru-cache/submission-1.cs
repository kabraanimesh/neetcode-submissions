public class LRUCache {
    public class Node {
        public int key;
        public int val;
        public Node next;
        public Node prev;

        public Node(int k, int v) {
            key = k;
            val = v;
            next = null;
            prev = null;
        }
    }
    Node head = new Node(-1, -1);
    Node tail = new Node(-1, -1);

    Dictionary<int, Node> map = new ();
    int limit;

    public void deleteNode(Node d) {
        var oldNext = d.next;
        var oldPrev = d.prev;

        oldPrev.next = oldNext;
        oldNext.prev = oldPrev;
    }

    public void addNode(Node a) {
        var oldNext = head.next;
        
        head.next = a;
        a.prev = head;

        a.next = oldNext;
        oldNext.prev = a;
    }

    public LRUCache(int capacity) {
        limit = capacity;
        head.next = tail;
        tail.prev = head;
    }
    
    public int Get(int key) {
        if (!map.ContainsKey(key)) {
            return -1;
        }

        var node = map[key];
        deleteNode(node);
        map.Remove(key);
        var nodetoAdd = new Node(key, node.val);
        addNode(nodetoAdd);
        map[key] = nodetoAdd;

        return nodetoAdd.val;
    }
    
    public void Put(int key, int value) {
        // Already exist
        if (map.ContainsKey(key)) {
            deleteNode(map[key]);
            map.Remove(key);
        }
        // Capacity
        if (map.Count() == limit) {
            map.Remove(tail.prev.key);
            deleteNode(tail.prev);
        }

        Node n = new Node(key, value);
        addNode(n);
        map[key] = n;
    }
}

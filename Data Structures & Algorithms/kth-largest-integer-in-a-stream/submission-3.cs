public class KthLargest {

    List<int> n;
    int i;     

    public KthLargest(int k, int[] nums) {
        i = k;
        n = nums.ToList();
    }
    
    public int Add(int val) {
        n.Add(val);
        n.Sort();
        return n[n.Count - i];
    }
}

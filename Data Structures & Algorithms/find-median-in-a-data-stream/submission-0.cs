public class MedianFinder {
PriorityQueue<int, int> minHeap;
    PriorityQueue<int, int> maxHeap;
    public MedianFinder() {
        minHeap = new();
        maxHeap = new();
    }
    
    public void AddNum(int num) {
        if (minHeap.TryPeek(out int minElement, out int _) && num < minElement) {
            minHeap.Enqueue(num, -num);
        }
        else if (maxHeap.TryPeek(out var maxElement, out int _) && num > maxElement) {
            maxHeap.Enqueue(num, num);
        }
        else {
            minHeap.Enqueue(num, -num);
        }

        if (minHeap.Count - maxHeap.Count > 1) {
            int pop = minHeap.Dequeue();
            maxHeap.Enqueue(pop, pop);
        }
        if (maxHeap.Count - minHeap.Count > 1) {
            int popped = maxHeap.Dequeue();
            minHeap.Enqueue(popped, -popped);
        }
    }
    
    public double FindMedian() {
        if (maxHeap.Count > minHeap.Count) {
            return maxHeap.Peek();
        }
        else if (minHeap.Count > maxHeap.Count) {
            return minHeap.Peek();
        }
        else {
            return 0.5 * (maxHeap.Peek() + minHeap.Peek());
        }
    }
}

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        //For kth Largest, we use MinHeap and for kth smallest, we use MaxHeap
        //In PriorityQueue, minHeap by default
        PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();
        foreach(var num in nums){
            minHeap.Enqueue(num,num);
            if(minHeap.Count>k){
                minHeap.Dequeue();
            }
        }
        return minHeap.Peek();

    }
}
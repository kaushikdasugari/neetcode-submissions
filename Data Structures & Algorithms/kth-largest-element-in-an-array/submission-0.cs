public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        
        int[] res = new int[k];

        PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();

        for(int i =0;i<nums.Length;i++){
            minHeap.Enqueue(nums[i],nums[i]);
            if(minHeap.Count > k)
                minHeap.Dequeue();
        }

        for(int i =0;i<k;i++){
            res[i] = minHeap.Dequeue();
        }

        return res[0];
    }
}

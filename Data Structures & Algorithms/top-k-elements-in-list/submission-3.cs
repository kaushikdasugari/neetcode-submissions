public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //Attempt 2 - Top K frequent - minheap

        int[] res = new int[k]; // return top k nums

        //Count the frequncies to a dict

        var nums_freq = Count_Frequencies(nums);

        //minheap
        PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();

        //load the minHeap
        foreach(KeyValuePair<int,int> rec in nums_freq){
            minHeap.Enqueue(rec.Key,rec.Value);
        }

        // dequeue the lowest ranked elements
        for(int i=0;i<nums.Length;i++){
            if(minHeap.Count > k)   minHeap.Dequeue();
        }

        //After dequeueing all the low ranked nums, return the remaining top ranked nums

        for(int i=0;i<k;i++){
            res[i] = minHeap.Dequeue();
        }

        return res;
        
    }

    public Dictionary<int,int> Count_Frequencies (int[] arr){
        Dictionary<int,int> freq = new Dictionary<int,int>();

        for(int i=0;i<arr.Length;i++){
            if(freq.ContainsKey(arr[i]))    freq[arr[i]]++;
            else freq[arr[i]] =1;
        }

        return freq;
    }
}

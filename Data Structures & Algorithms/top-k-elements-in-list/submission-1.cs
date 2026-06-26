public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        int[] res = new int[k];// return my array of top k elements

        Dictionary<int,int>  freq = new Dictionary<int,int>();

        //loop over dict to get the freq count
        for(int i=0;i<nums.Length;i++){
            if(freq.ContainsKey(nums[i])){
                freq[nums[i]]++;
            }

            else{
                freq[nums[i]] = 1;
            }
        }

        //must return the top k values not the freq count match, like a rank.
        // sort the dict by the freq value(rank)'
        //one of the way to sort a dict
        res = freq.OrderByDescending(rec => rec.Value)
                         .Take(k)
                         .Select(rec => rec.Key)
                         .ToArray();
       
        return res;
    }
}

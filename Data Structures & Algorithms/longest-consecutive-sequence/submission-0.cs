public class Solution {
    public int LongestConsecutive(int[] nums) {

       int longest = 0;

        // map array to a hashset
        HashSet<int> map = new HashSet<int>();
        foreach(int num in nums){
            if(!map.Contains(num)) map.Add(num);
        }

        // find every number that could be the start of a sequence
        for(int i = 0; i < nums.Length; i++){
            if(!map.Contains(nums[i] - 1)){
                int startSeq = nums[i];

                // walk forward from startSeq, counting consecutive numbers
                int consecCount = 1;
                while(map.Contains(startSeq + 1)){
                    startSeq = startSeq + 1;
                    consecCount++;
                }

                // keep the best one found so far
                if(consecCount > longest){
                    longest = consecCount;
                }
            }
        }

        return longest;
        
    }
}

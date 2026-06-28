public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        HashSet<int> hasSeen = new HashSet<int>();
        //O(n) and O(1) lookup as we are using HashSet
        for(int i=0;i<nums.Length;i++){
            if(hasSeen.Contains(nums[i])) return true;
            else hasSeen.Add(nums[i]);
        }

        return false;
    }
}
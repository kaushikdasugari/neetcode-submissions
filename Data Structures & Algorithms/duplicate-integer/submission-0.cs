public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        //HashSet
        HashSet<int> uniq = new();

        //loop over array
        for(int i=0;i<nums.Length;i++){
            if(uniq.Contains(nums[i])){
                return true;
            }
            else{
                uniq.Add(nums[i]);
            }
        }
        return false;
    }
}
public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        
        //Approach 2 - tyring hint 2, can i sort the array and solve the problem?

        List<List<int>> output = new List<List<int>>();

        Array.Sort(nums);

       

        for(int i=0;i<nums.Length;i++){
            if(i>0 && nums[i] == nums[i-1]) continue;
            int left = i+1;
            int right = nums.Length-1;
            int a = nums[i];

            while(left < right){
                int b = nums[left] + nums[right];
                if((a+b) > 0){
                    right--;
                }

                else if((a+b) < 0){
                    left++;
                }

                else if((a + b) == 0){
                        output.Add([nums[i],nums[left],nums[right]]);
                        left++;
                        right--;
                        // you can break the loop if you want but moving pointers inward can help if there are any missing conditions
               
                        while(left < right && nums[left] == nums[left-1]) left++;
                        while (left < right && nums[right] == nums[right+1]) right--;               
               }
            }
        }

        return output;
        // you can also implement dedup logic of DistinctBy(list => string.Join(",", list.OrderBy(x => x)))
    //.ToList();
    }
}

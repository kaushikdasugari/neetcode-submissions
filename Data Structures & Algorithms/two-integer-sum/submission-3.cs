public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int[] res = new int[2];

        List<int> map = new List<int>();;

        //map all the values to a list
        for(int i=0;i<nums.Length;i++){
            map.Add(nums[i]);
        }

        for(int i=0;i<nums.Length;i++){

            var numExist = target-nums[i];
          
            if(map.Contains(numExist) && map.IndexOf(numExist) != i){
               
                 res[0] = i;
                 res[1] = map.IndexOf(numExist);

                 Array.Sort(res);
               
            }
        }

        return res;
    }
}
